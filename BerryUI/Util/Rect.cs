using System;
using System.Diagnostics;
using System.Numerics;

namespace BerryUI.Util;

/// Describes an integer 2D-Rect.
[Serializable]
[DebuggerDisplay("{DebugDisplayString,nq}")]
public struct Rect<T>(T x, T y, T w, T h)
    : IEquatable<Rect<T>>
    where T : INumber<T>, IMinMaxValue<T> {
    /// Empty rectangle with the dimensions 0x0.
    public static readonly Rect<T> Empty = new(T.Zero, T.Zero, T.Zero, T.Zero);
    /// Largest possible rectangle which the backing type can support.
    public static readonly Rect<T> Max = new(T.Zero, T.Zero, T.MaxValue, T.MaxValue);

    /// The x coordinate of this <see cref="Rect{T}"/>.
    public T X = x;

    /// The y coordinate of this <see cref="Rect{T}"/>.
    public T Y = y;

    /// The width dimension of this <see cref="Rect{T}"/>.
    public T Width = w;

    /// The height dimension of this <see cref="Rect{T}"/>.
    public T Height = h;

    /// The left edge of this <see cref="Rect{T}"/>.
    public T Left { get => X; set => X = value; }

    /// The right edge of this <see cref="Rect{T}"/>.
    public T Right { get => X + Width; set => Width = value - X; }

    /// The top edge of this <see cref="Rect{T}"/>.
    public T Top { get => Y; set => Y = value; }

    /// The bottom edge of this <see cref="Rect{T}"/>.
    public T Bottom { get => Y + Height; set => Height = value - Y; }

    /// The <see cref="Point{T}"/> of this <see cref="Rect{T}"/>.
    public Point<T> Point {
        get => new(X, Y);
        set {
            X = value.X;
            Y = value.Y;
        }
    }

    /// The <see cref="Size{T}"/> of this <see cref="Rect{T}"/>.
    public Size<T> Size {
        get => new(Width, Height);
        set {
            Width = value.Width;
            Height = value.Height;
        }
    }

    public Point<T> TopLeft {
        get => new(Left, Top);
        set {
            Left = value.X;
            Top = value.Y;
        }
    }
    public Point<T> TopRight {
        get => new(Right, Top);
        set {
            Right = value.X;
            Top = value.Y;
        }
    }
    public Point<T> BottomLeft {
        get => new(Left, Bottom);
        set {
            Left = value.X;
            Bottom = value.Y;
        }
    }
    public Point<T> BottomRight {
        get => new(Right, Bottom);
        set {
            Right = value.X;
            Bottom = value.Y;
        }
    }

    public Rect(Point<T> point, Size<T> size)
        : this(point.X, point.Y, size.Width, size.Height) {
    }

    public static Rect<T> FromEdges(T left, T right, T top, T bottom) {
        return new Rect<T>(left, top, right - left, bottom - top);
    }

    public static Rect<T> FromSize(Size<T> size) {
        return new Rect<T>(T.Zero, T.Zero, size.Width, size.Height);
    }

    public static Rect<T> FromSize(T width, T height) {
        return new Rect<T>(T.Zero, T.Zero, width, height);
    }

    /// Combines both rectangles into a bigger one which contains both of them.
    public static Rect<T> Combine(Rect<T> a, Rect<T> b) {
        return FromEdges(
            left: T.Min(a.Left, b.Left),
            right: T.Max(a.Right, b.Right),
            top: T.Min(a.Top, b.Top),
            bottom: T.Max(a.Bottom, b.Bottom));
    }

    /// Compares both rectangles and checks if they overlap each other.
    public static bool Intersects(Rect<T> a, Rect<T> b) {
        return a.Right > b.Left && a.Left < b.Right &&
               a.Bottom > b.Top && a.Top < b.Bottom;
    }

    public static bool operator ==(Rect<T> a, Rect<T> b) => a.Equals(b);
    public static bool operator !=(Rect<T> a, Rect<T> b) => !a.Equals(b);

    public bool Equals(Rect<T> other) =>
        Left == other.Left &&
        Right == other.Right &&
        Top == other.Top &&
        Bottom == other.Bottom;

    public override bool Equals(object? obj) => obj is Rect<T> other && Equals(other);
    public override string ToString() => $"{{X:{X} Y:{Y} W:{Width} H:{Height}}}";

    public override int GetHashCode() {
        var hash = new HashCode();
        hash.Add(X);
        hash.Add(Y);
        hash.Add(Width);
        hash.Add(Height);
        return hash.ToHashCode();
    }

    internal string DebugDisplayString => $"{X} {Y} {Width} {Height}";
}
