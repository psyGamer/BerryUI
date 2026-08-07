using System;
using System.Diagnostics;
using System.Numerics;

namespace BerryUI.Util;

/// Describes an integer 2D-Rect.
[Serializable]
[DebuggerDisplay("{DebugDisplayString,nq}")]
public struct Rect<T>(T left, T right, T top, T bottom)
    : IEquatable<Rect<T>>
    where T : INumber<T> {
    public static readonly Rect<T> Zero = new(T.Zero, T.Zero, T.Zero, T.Zero);

    /// The left edge of this <see cref="Rect{T}"/>.
    public T Left = left;

    /// The right edge of this <see cref="Rect{T}"/>.
    public T Right = right;

    /// The top edge of this <see cref="Rect{T}"/>.
    public T Top = top;

    /// The bottom edge of this <see cref="Rect{T}"/>.
    public T Bottom = bottom;

    /// The x coordinate of this <see cref="Rect{T}"/>.
    public T X { get => Left; set => Left = value; }

    /// The y coordinate of this <see cref="Rect{T}"/>.
    public T Y { get => Top; set => Top = value; }

    /// The width dimension of this <see cref="Rect{T}"/>.
    public T Width { get => Right - Left; set => Right = Left + value; }

    /// The height dimension of this <see cref="Rect{T}"/>.
    public T Height { get => Bottom - Top; set => Bottom = Top + value; }

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

    public Rect(Point<T> point, Size<T> size)
        : this(point.X, point.X + size.Width, point.Y, point.Y + size.Height)
    { }

    public static bool operator ==(Rect<T> a, Rect<T> b) => a.Equals(b);
    public static bool operator !=(Rect<T> a, Rect<T> b) => !a.Equals(b);

    public bool Equals(Rect<T> other) =>
        Left == other.Left &&
        Right == other.Right &&
        Top == other.Top &&
        Bottom == other.Bottom;

    public override bool Equals(object? obj) => obj is Rect<T> other && Equals(other);
    public override string ToString() => $"{{Left:{Left} Right:{Right} Top:{Top} Bottom:{Bottom}}}";

    public override int GetHashCode() {
        var hash = new HashCode();
        hash.Add(Left);
        hash.Add(Right);
        hash.Add(Top);
        hash.Add(Bottom);
        return hash.ToHashCode();
    }

    internal string DebugDisplayString => $"{Left} {Right} {Top} {Bottom}";
}
