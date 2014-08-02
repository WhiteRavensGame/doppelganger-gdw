Shader "Custom/Diffuse Vertex Color" {
  Properties {
    _MainTex ("Texture", 2D) = "white" {}
  }
  SubShader {
    Tags { "RenderType" = "Opaque" }

    ColorMask RGB

    CGPROGRAM
    #pragma surface surf Lambert addshadow fullforwardshadows

    sampler2D _MainTex;

    struct Input {
        float4 color : COLOR; // interpolated vertex color
        float2 uv_MainTex;
    };

    void surf (Input IN, inout SurfaceOutput o) {
        fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * IN.color;
        o.Albedo = c.rgb;
    }
    ENDCG
  }
  Fallback "Diffuse"
}
