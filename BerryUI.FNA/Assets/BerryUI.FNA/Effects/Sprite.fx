// Compile with "fxc /O3 /T fx_2_0 /Fo Sprite.fxb Sprite.fx"

#include "Common.fxh"

float4 PS_Main(float2 texCoordFg : TEXCOORD0,
               float2 texCoordBg : TEXCOORD1,
               float4 color      : COLOR0) : SV_TARGET0 
{
    if (texCoordFg.x > 1.0 && texCoordFg.y > 1.0) {
        // Special Case: Blit to the screen with conversion from linear to sRGB
        float4 background     = tex2D(BackgroundSampler, texCoordBg);
               background.rgb = pow(background.rgb, OutputGamma);
        return background;
    }

    // Transform user-texture from sRGB to linear
    float4 output     = tex2D(TextureSampler, texCoordFg) * color;
           output.rgb = pow(output.rgb, InputGamma);
           
    // Transform output back from linear to sRGB when drawing to screen
    return float4(pow(output.rgb, OutputGamma), output.a);
}

technique
{
    pass
    {
        VertexShader = compile vs_2_0 VS_Main();
        PixelShader  = compile ps_2_0 PS_Main();
    }
}

