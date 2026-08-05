using System;
using System.Diagnostics;

namespace BerryUI.Util;

/// Describes an integer 2D-point.
[Serializable]
[DebuggerDisplay("{DebugDisplayString,nq}")]
public struct Point(int x, int y) : IEquatable<Point> {
    public static readonly Point Zero = new(0, 0);

    /// The x coordinate of this <see cref="Point"/>.
    public int X = x;

    /// The y coordinate of this <see cref="Point"/>.
    public int Y = y;

    public static Point operator +(Point value1, Point value2) => new(value1.X + value2.X, value1.Y + value2.Y);
    public static Point operator -(Point value1, Point value2) => new(value1.X - value2.X, value1.Y - value2.Y);
    public static Point operator *(Point value1, Point value2) => new(value1.X * value2.X, value1.Y * value2.Y);
    public static Point operator /(Point value1, Point value2) => new(value1.X / value2.X, value1.Y / value2.Y);

    public static bool operator ==(Point a, Point b) => a.Equals(b);
    public static bool operator !=(Point a, Point b) => !a.Equals(b);

    public bool Equals(Point other) => X == other.X && (Y == other.Y);
    public override bool Equals(object? obj) => obj is Point other && Equals(other);
    public override string ToString() => $"{{X:{X} Y:{Y}}}";

    public override int GetHashCode() {
        var hash = new HashCode();
        hash.Add(X);
        hash.Add(Y);
        return hash.ToHashCode();
    }

    internal string DebugDisplayString => $"{X} {Y}";
}
