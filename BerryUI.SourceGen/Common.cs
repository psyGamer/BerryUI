using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace BerryUI.SourceGen;

internal sealed record TypeDefinition(string Keyword, string Namespace, string Name, bool IsReadonly) {
    public TypeDefinition? Parent;
    public string[] Interfaces = [];

    public static TypeDefinition FromSymbol(INamedTypeSymbol symbol, TypeDeclarationSyntax typeDecl) {
        string? ns = symbol.ContainingNamespace?.ToDisplayString(
            SymbolDisplayFormat.FullyQualifiedFormat.WithGlobalNamespaceStyle(SymbolDisplayGlobalNamespaceStyle.Omitted));

        var type = new TypeDefinition(
            typeDecl is RecordDeclarationSyntax recordDecl ? $"{typeDecl.Keyword.ValueText} {recordDecl.ClassOrStructKeyword}" : typeDecl.Keyword.ValueText,
            ns ?? string.Empty,
            $"{typeDecl.Identifier}{typeDecl.TypeParameterList}",
            typeDecl.Modifiers.Any(m => m.IsKind(SyntaxKind.ReadOnlyKeyword)));

        var current = type;
        var parentDecl = typeDecl.Parent as TypeDeclarationSyntax;
        while (parentDecl is not null) {
            current.Parent = new TypeDefinition(
                parentDecl is RecordDeclarationSyntax parentRecordDecl ? $"{parentDecl.Keyword.ValueText} {parentRecordDecl.ClassOrStructKeyword}" : parentDecl.Keyword.ValueText,
                ns ?? string.Empty,
                $"{parentDecl.Identifier}{parentDecl.TypeParameterList}",
                parentDecl.Modifiers.Any(m => m.IsKind(SyntaxKind.ReadOnlyKeyword)));

            current = current.Parent;
            parentDecl = parentDecl.Parent as TypeDeclarationSyntax;
        }

        type.Interfaces = symbol.Interfaces.Select(i => i.ToDisplayString()).ToArray();

        return type;
    }
}

internal static class Extensions {
    public static bool CalcUnmanaged(this ITypeSymbol symbol, out uint size, out uint align) {
        switch (symbol.SpecialType) {
            case SpecialType.System_Byte:
            case SpecialType.System_SByte:
                size = align = 1;
                return true;
            case SpecialType.System_Int16:
            case SpecialType.System_UInt16:
                size = align = 2;
                return true;
            case SpecialType.System_Int32:
            case SpecialType.System_UInt32:
                size = align = 4;
                return true;
            case SpecialType.System_Int64:
            case SpecialType.System_UInt64:
                size = align = 8;
                return true;
            case SpecialType.System_Single:
                size = align = 4;
                return true;
            case SpecialType.System_Double:
                size = align = 8;
                return true;
            case SpecialType.System_IntPtr:
            case SpecialType.System_UIntPtr:
                // Assume 64-bit
                size = align = 8;
                return true;
        }

        if (symbol.TypeKind is TypeKind.Pointer) {
            // Assume 64-bit
            size = align = 8;
            return true;
        }

        if (symbol is INamedTypeSymbol namedType) {
            if (namedType.EnumUnderlyingType is { } enumType) {
                return enumType.CalcUnmanaged(out size, out align);
            }

            size = align = 0;
            if (!namedType.IsValueType) {
                return false;
            }

            var layoutAttr = namedType
                .GetAttributes()
                .FirstOrDefault(attr => attr.AttributeClass?.ToDisplayString() == $"System.Runtime.InteropServices.{nameof(StructLayoutAttribute)}");
            var layoutKind = layoutAttr?.ConstructorArguments[0].Value switch {
                int val => (LayoutKind) val,
                LayoutKind val => val,
                _ => LayoutKind.Sequential,
            };
            int? layoutPack = layoutAttr?.NamedArguments.FirstOrDefault(pair => pair.Key == nameof(StructLayoutAttribute.Pack)).Value.Value as int?;
            int? layoutSize = layoutAttr?.NamedArguments.FirstOrDefault(pair => pair.Key == nameof(StructLayoutAttribute.Size)).Value.Value as int?;

            var fields = namedType.GetMembers()
                .Select(member => member is IFieldSymbol { IsStatic: false } field ? field : null!)
                .Where(field => field != null);

            switch (layoutKind) {
                case LayoutKind.Sequential:
                    foreach (var field in fields) {
                        if (!field.Type.CalcUnmanaged(out uint fieldSize, out uint fieldAlign)) {
                            return false;
                        }
                        if (layoutPack.HasValue) {
                            fieldAlign = Math.Min(fieldAlign, (uint)layoutPack.Value);
                        }

                        size = ((size + (fieldAlign - 1)) & ~(fieldAlign - 1)) + fieldSize;
                        align = Math.Max(align, fieldAlign);
                    }

                    return true;
                case LayoutKind.Explicit:
                    foreach (var field in fields) {
                        var offsetAttr = field
                            .GetAttributes()
                            .FirstOrDefault(attr => attr.AttributeClass?.ToDisplayString() == $"System.Runtime.InteropServices.{nameof(FieldOffsetAttribute)}");
                        if (offsetAttr == null) {
                            return false;
                        }
                        uint offset = (uint)(int)offsetAttr.ConstructorArguments[0].Value!;

                        if (!field.Type.CalcUnmanaged(out uint fieldSize, out uint fieldAlign)) {
                            return false;
                        }
                        if (layoutPack.HasValue) {
                            fieldAlign = Math.Min(fieldAlign, (uint)layoutPack.Value);
                        }

                        size = Math.Max(size, offset + fieldSize);
                        align = Math.Max(align, fieldAlign);
                    }

                    return true;
                case LayoutKind.Auto:
                    var arr = fields.ToArray();
                    var values = new (uint Size, uint Align)[arr.Length];

                    for (int i = 0; i < arr.Length; i++) {
                        var field = arr[i];
                        if (!field.Type.CalcUnmanaged(out uint fieldSize, out uint fieldAlign)) {
                            return false;
                        }
                        if (layoutPack.HasValue) {
                            fieldAlign = Math.Min(fieldAlign, (uint)layoutPack.Value);
                        }

                        values[i] = (fieldSize, fieldAlign);
                    }

                    Array.Sort(values, (lhs, rhs) => (int)rhs.Align - (int)lhs.Align);
                    foreach ((uint fieldSize, uint fieldAlign) in values) {
                        size = ((size + (fieldAlign - 1)) & ~(fieldAlign - 1)) + fieldSize;
                        align = Math.Max(align, fieldAlign);
                    }

                    return true;
            }


        }

        size = align = 0;
        return false;
    }
}
