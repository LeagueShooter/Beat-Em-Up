﻿// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Hidden/Highlighted/Blit"
{
	Properties
	{
		[HideInInspector] _MainTex ("", 2D) = "" {}
	}
	
	SubShader
	{
		Pass
		{
			Lighting Off
			Fog { Mode off }
			ZWrite Off
			ZTest Always
			Cull Off
			Blend Off
			
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest
			
			#include "UnityCG.cginc"
			
			struct v2f
			{
				float4 pos : POSITION;
				half2 uv : TEXCOORD0;
			};
			
			uniform sampler2D _MainTex;
			
			v2f vert(appdata_img v)
			{
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				o.uv = v.texcoord.xy;					
				return o;
			}
			
			fixed4 frag(v2f i) : COLOR
			{
				return tex2D(_MainTex, i.uv);
			}
			ENDCG
		}
	}
	FallBack Off
}
