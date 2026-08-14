texture Texture : register(t0);
sampler TextureSampler : register(s0);

texture Background : register(t1);
sampler BackgroundSampler : register(s1);

float4x4 Matrix;
float2 TextureSize;

float InputGamma;
float OutputGamma;

void VS_Main(inout float4 position   : SV_Position,
             inout float2 texCoordFg : TEXCOORD0,
               out float2 texCoordBg : TEXCOORD1,
             inout float4 color      : COLOR0)
{
    position = mul(position, Matrix);

    texCoordFg /= TextureSize;

    texCoordBg    = position.xy * 0.5 + 0.5;
    texCoordBg.y *= -1.0;
}