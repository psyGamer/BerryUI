using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BerryUI.FNA.FreeType;

[GeneratedCode("ClangSharp", "22.1.8.0")]
public partial struct PS_PrivateRec
{
    [NativeTypeName("FT_Int")]
    public int unique_id;

    [NativeTypeName("FT_Int")]
    public int lenIV;

    [NativeTypeName("FT_Byte")]
    public byte num_blue_values;

    [NativeTypeName("FT_Byte")]
    public byte num_other_blues;

    [NativeTypeName("FT_Byte")]
    public byte num_family_blues;

    [NativeTypeName("FT_Byte")]
    public byte num_family_other_blues;

    [NativeTypeName("FT_Short[14]")]
    public _blue_values_e__FixedBuffer blue_values;

    [NativeTypeName("FT_Short[10]")]
    public _other_blues_e__FixedBuffer other_blues;

    [NativeTypeName("FT_Short[14]")]
    public _family_blues_e__FixedBuffer family_blues;

    [NativeTypeName("FT_Short[10]")]
    public _family_other_blues_e__FixedBuffer family_other_blues;

    [NativeTypeName("FT_Fixed")]
    public nint blue_scale;

    [NativeTypeName("FT_Int")]
    public int blue_shift;

    [NativeTypeName("FT_Int")]
    public int blue_fuzz;

    [NativeTypeName("FT_UShort[1]")]
    public _standard_width_e__FixedBuffer standard_width;

    [NativeTypeName("FT_UShort[1]")]
    public _standard_height_e__FixedBuffer standard_height;

    [NativeTypeName("FT_Byte")]
    public byte num_snap_widths;

    [NativeTypeName("FT_Byte")]
    public byte num_snap_heights;

    [NativeTypeName("FT_Bool")]
    public byte force_bold;

    [NativeTypeName("FT_Bool")]
    public byte round_stem_up;

    [NativeTypeName("FT_Short[13]")]
    public _snap_widths_e__FixedBuffer snap_widths;

    [NativeTypeName("FT_Short[13]")]
    public _snap_heights_e__FixedBuffer snap_heights;

    [NativeTypeName("FT_Fixed")]
    public nint expansion_factor;

    [NativeTypeName("FT_Long")]
    public nint language_group;

    [NativeTypeName("FT_Long")]
    public nint password;

    [NativeTypeName("FT_Short[2]")]
    public _min_feature_e__FixedBuffer min_feature;

    [InlineArray(14)]
    public partial struct _blue_values_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(10)]
    public partial struct _other_blues_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(14)]
    public partial struct _family_blues_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(10)]
    public partial struct _family_other_blues_e__FixedBuffer
    {
        public short e0;
    }

    public partial struct _standard_width_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }

    public partial struct _standard_height_e__FixedBuffer
    {
        public ushort e0;

        [UnscopedRef]
        public ref ushort this[int index]
        {
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [UnscopedRef]
        public Span<ushort> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }

    [InlineArray(13)]
    public partial struct _snap_widths_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(13)]
    public partial struct _snap_heights_e__FixedBuffer
    {
        public short e0;
    }

    [InlineArray(2)]
    public partial struct _min_feature_e__FixedBuffer
    {
        public short e0;
    }
}
