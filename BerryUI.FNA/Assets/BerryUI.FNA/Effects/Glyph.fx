// Compile with "fxc /O3 /T fx_2_0 /Fo Glyph.fxb Glyph.fx"

#include "Common.fxh"

float4 PS_Main(float2 texCoordFg : TEXCOORD0,
               float2 texCoordBg : TEXCOORD1,
               float4 color      : COLOR0) : SV_TARGET0
{
    float3 background = tex2D(BackgroundSampler, texCoordBg).rgb;
    // Transform user-color from sRGB to linear
    float3 foreground = pow(color.rgb, InputGamma);
    
    // Font brightness is already in linear space
    float3 brightness = tex2D(TextureSampler, texCoordFg).rgb * color.a;
    float3 output = lerp(background, foreground, brightness);

    // Transform output back from linear to sRGB when drawing to screen
    return float4(pow(output, OutputGamma), 1.0);
}

technique
{
    pass
    {
        VertexShader = compile vs_2_0 VS_Main();
        PixelShader  = compile ps_2_0 PS_Main();
    }
}

