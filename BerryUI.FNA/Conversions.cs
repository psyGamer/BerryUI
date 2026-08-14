using BerryUI.Util;
using Microsoft.Xna.Framework;
using System.Numerics;
using System.Runtime.CompilerServices;
using FNAColor = Microsoft.Xna.Framework.Color;
using BerryColor = BerryUI.Util.Color;
using Vector2 = Microsoft.Xna.Framework.Vector2;
using Vector3 = Microsoft.Xna.Framework.Vector3;

namespace BerryUI.FNA;

public static class Conversions {

    public static Rectangle ToFNA<T>(this Rect<T> rect) where T : INumber<T>, IMinMaxValue<T> {
        return new Rectangle(
            int.CreateChecked(rect.X),
            int.CreateChecked(rect.Y),
            int.CreateChecked(rect.Width),
            int.CreateChecked(rect.Height));
    }

    public static FNAColor ToFNA(this BerryColor color) {
        // They have the same memory representation
        return Unsafe.BitCast<BerryColor, FNAColor>(color);
    }

    public static Vector2 ToVector2<T>(this Point<T> point) where T : INumber<T> {
        return new Vector2(
            float.CreateChecked(point.X),
            float.CreateChecked(point.Y));
    }
    public static Vector3 ToVector3<T>(this Point<T> point) where T : INumber<T> {
        return new Vector3(
            float.CreateChecked(point.X),
            float.CreateChecked(point.Y),
            0.0f);
    }
}
