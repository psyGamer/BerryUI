using System;
using System.Diagnostics;
using System.Numerics;

namespace BerryUI.Util;

/// Describes a 2D-point.
[Serializable]
[DebuggerDisplay("{DebugDisplayString,nq}")]
public struct Point<T>(T x, T y) : IEquatable<Point<T>> where T : INumber<T> {
    public static readonly Point<T> Zero = new(T.Zero, T.Zero);

    /// The x coordinate of this <see cref="Point{T}"/>.
    public T X = x;

    /// The y coordinate of this <see cref="Point{T}"/>.
    public T Y = y;

    public static Point<T> operator +(Point<T> lhs, Point<T> rhs) => new(lhs.X + rhs.X, lhs.Y + rhs.Y);
    public static Point<T> operator -(Point<T> lhs, Point<T> rhs) => new(lhs.X - rhs.X, lhs.Y - rhs.Y);
    public static Point<T> operator *(Point<T> lhs, Point<T> rhs) => new(lhs.X * rhs.X, lhs.Y * rhs.Y);
    public static Point<T> operator /(Point<T> lhs, Point<T> rhs) => new(lhs.X / rhs.X, lhs.Y / rhs.Y);

    public static bool operator ==(Point<T> a, Point<T> b) => a.Equals(b);
    public static bool operator !=(Point<T> a, Point<T> b) => !a.Equals(b);

    public bool Equals(Point<T> other) =>
        X == other.X &&
        Y == other.Y;

    public override bool Equals(object? obj) => obj is Point<T> other && Equals(other);
    public override string ToString() => $"{{X:{X} Y:{Y}}}";

    public override int GetHashCode() {
        var hash = new HashCode();
        hash.Add(X);
        hash.Add(Y);
        return hash.ToHashCode();
    }

    internal string DebugDisplayString => $"{X} {Y}";
}
