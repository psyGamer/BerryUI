using BerryUI.Util;
using Microsoft.Xna.Framework;
using System.Numerics;
using System.Runtime.CompilerServices;
using FNAColor = Microsoft.Xna.Framework.Color;
using BerryColor = BerryUI.Util.Color;

namespace BerryUI.FNA;

public static class Conversions {

    public static Rectangle ToFNA<T>(this Rect<T> rect) where T : INumber<T> {
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
}
