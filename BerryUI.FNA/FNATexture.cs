using BerryUI.Util;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BerryColor = BerryUI.Util.Color;
using BerryTexture = BerryUI.Render.Texture;

namespace BerryUI.FNA;

public sealed class FNATexture : IDisposable {
    public readonly Texture2D Texture;

    public ResourceHandle<BerryTexture> Handle { get; set; }

    public FNATexture(GraphicsDevice gd, int width, int height, BerryColor? fillColor) {
        Texture = new Texture2D(gd, width, height, false, SurfaceFormat.Color);
        if (fillColor.HasValue) {
            unsafe {
                int dataLen = width * height;
                int dataSize = dataLen * Unsafe.SizeOf<BerryColor>();

                nint dataPtr = Marshal.AllocHGlobal(dataSize);
                var dataSpan = new Span<BerryColor>((void*)dataPtr, dataLen);
                dataSpan.Fill(fillColor.Value);

                Texture.SetDataPointerEXT(0, null, dataPtr, dataSize);

                Marshal.FreeHGlobal(dataPtr);
            }
        }
    }

    public void Dispose() {
        Texture.Dispose();
    }
}
