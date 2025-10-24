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
                fixed4 col = saturate(tex2D(_MainTex, i.uv));

                float maxColor = COLORS - 1.0; // Value of the numbers of colors
                float halfColX = 0.5 / _LUT_TexelSize.z;
                float halfColY = 0.5 / _LUT_TexelSize.w;
                float threshold = maxColor / COLORS;

                float xOffset = halfColX + col.r * threshold / COLORS;
                float yOffset = halfColY + col.g * threshold;
                float cell = floor(col.b * maxColor);

                float2 lutPos = float2(cell / COLORS + xOffset, yOffset);
                float4 gradedCol = tex2D(_LUT, lutPos);

                return lerp(col, gradedCol, _Contribution);
            }

            ENDCG
        }
    }
}
