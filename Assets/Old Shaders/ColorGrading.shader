Shader "Custom/URP_LUTColorGrading"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _LUT ("LUT", 2D) = "white" {}
        _Contribution ("Contribution", Range(0, 1)) = 1
    }

    SubShader
    {
        // Makes sure the effect is shown
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            // Uses unity built in shader
            #include "UnityCG.cginc"

            // Defines how many colors is on out LUT
            #define COLORS 32.0

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            
            sampler2D _MainTex;
            sampler2D _LUT;
            float4 _LUT_TexelSize; // Dimensions of the texture
            float _Contribution;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                // Get the color from the main image at this pixel
                fixed4 col = saturate(tex2D(_MainTex, i.uv));

                // The LUT has 32 slices
                float maxColor = COLORS - 1.0;

                // Sample from the middle of LUT
                float halfColX = 0.5 / _LUT_TexelSize.z;
                float halfColY = 0.5 / _LUT_TexelSize.w;

                // Each slice covers 1/32 of the LUT
                float threshold = maxColor / COLORS;

                // Find the pixel’s position inside the LUT:. Red moves along the x axis inside the slice and green moves along the y axis.
                float xOffset = halfColX + col.r * threshold / COLORS;
                float yOffset = halfColY + col.g * threshold;
                float cell = floor(col.b * maxColor);

                // Turn that 3D color position into 2D UVs for the LUT texture
                float2 lutPos = float2(cell / COLORS + xOffset, yOffset);

                // Sample the color from the LUT using those UVs
                float4 gradedCol = tex2D(_LUT, lutPos);

                // Blend between the original color and the LUT color
                return lerp(col, gradedCol, _Contribution); // _Contribution = 0 means no effect, 1 means fully graded
            }

            ENDCG
        }
    }
}
