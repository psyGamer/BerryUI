using System;
using System.Diagnostics;
using System.Numerics;

namespace BerryUI.Util;

/// Describes a 2D-size.
[Serializable]
[DebuggerDisplay("{DebugDisplayString,nq}")]
public struct Size<T>(T width, T height) : IEquatable<Size<T>> where T : INumber<T>, IMinMaxValue<T> {
    public static readonly Size<T> Zero = new(T.Zero, T.Zero);

    /// The width dimension of this <see cref="Size{T}"/>.
    public T Width = width;

    /// The height dimension of this <see cref="Size{T}"/>.
    public T Height = height;

    public Rect<T> WithPoint(Point<T> point) {
        return new Rect<T>(point, this);
    }

    public static Size<T> operator +(Size<T> lhs, Size<T> rhs) => new(lhs.Width + rhs.Width, lhs.Height + rhs.Height);
    public static Size<T> operator -(Size<T> lhs, Size<T> rhs) => new(lhs.Width - rhs.Width, lhs.Height - rhs.Height);
    public static Size<T> operator *(Size<T> lhs, Size<T> rhs) => new(lhs.Width * rhs.Width, lhs.Height * rhs.Height);
    public static Size<T> operator /(Size<T> lhs, Size<T> rhs) => new(lhs.Width / rhs.Width, lhs.Height / rhs.Height);

    public static bool operator ==(Size<T> a, Size<T> b) => a.Equals(b);
    public static bool operator !=(Size<T> a, Size<T> b) => !a.Equals(b);

    public bool Equals(Size<T> other) =>
        Width == other.Width &&
        Height == other.Height;

    public override bool Equals(object? obj) => obj is Size<T> other && Equals(other);
    public override string ToString() => $"{{Width:{Width} Height:{Height}}}";

    public override int GetHashCode() {
        var hash = new HashCode();
        hash.Add(Width);
        hash.Add(Height);
        return hash.ToHashCode();
    }

    internal string DebugDisplayString => $"{Width} {Height}";
}
