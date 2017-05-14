// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

// Shader created with Shader Forge v1.36 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.36;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33473,y:32706,varname:node_9361,prsc:2|emission-562-OUT,custl-5085-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:8068,x:32734,y:33086,varname:node_8068,prsc:2;n:type:ShaderForge.SFN_LightColor,id:3406,x:32734,y:32952,varname:node_3406,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:851,x:32070,y:32349,ptovrint:False,ptlb:Main Texture,ptin:_MainTexture,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-2347-UVOUT;n:type:ShaderForge.SFN_Color,id:5927,x:32070,y:32534,ptovrint:False,ptlb:Main Color,ptin:_MainColor,varname:node_5927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Multiply,id:5085,x:33117,y:32938,cmnt:Attenuate and Color,varname:node_5085,prsc:2|A-544-OUT,B-3406-RGB,C-8068-OUT;n:type:ShaderForge.SFN_AmbientLight,id:7528,x:32734,y:32646,varname:node_7528,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2460,x:32927,y:32598,cmnt:Ambient Light,varname:node_2460,prsc:2|A-544-OUT,B-7528-RGB;n:type:ShaderForge.SFN_Multiply,id:544,x:32410,y:32454,cmnt:Diffuse Color,varname:node_544,prsc:2|A-851-RGB,B-5927-RGB,C-6614-RGB;n:type:ShaderForge.SFN_TexCoord,id:2347,x:31831,y:32329,varname:node_2347,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:6614,x:32081,y:32107,ptovrint:False,ptlb:Multiply Texture,ptin:_MultiplyTexture,varname:_MainTexture_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-3188-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:3188,x:31831,y:32094,varname:node_3188,prsc:2,uv:1,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:3178,x:32081,y:31905,ptovrint:False,ptlb:Additive Texture,ptin:_AdditiveTexture,varname:_MultiplyTexture_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-2537-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:2537,x:31820,y:31897,varname:node_2537,prsc:2,uv:2,uaff:False;n:type:ShaderForge.SFN_Color,id:9013,x:32081,y:31719,ptovrint:False,ptlb:Additive Color,ptin:_AdditiveColor,varname:_MainColor_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Add,id:562,x:33130,y:32397,varname:node_562,prsc:2|A-8283-OUT,B-2460-OUT;n:type:ShaderForge.SFN_Multiply,id:6816,x:32534,y:31842,varname:node_6816,prsc:2|A-9013-RGB,B-3178-RGB;n:type:ShaderForge.SFN_Slider,id:141,x:32305,y:32066,ptovrint:False,ptlb:Emmision Power,ptin:_EmmisionPower,varname:node_141,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:10;n:type:ShaderForge.SFN_Multiply,id:8283,x:32709,y:31967,varname:node_8283,prsc:2|A-6816-OUT,B-141-OUT;proporder:851-5927-6614-3178-9013-141;pass:END;sub:END;*/

Shader "Dwarfs/CustomLight" {
    Properties {
        _MainTexture ("Main Texture", 2D) = "white" {}
        _MainColor ("Main Color", Color) = (0.5,0.5,0.5,1)
        _MultiplyTexture ("Multiply Texture", 2D) = "white" {}
        _AdditiveTexture ("Additive Texture", 2D) = "white" {}
        _AdditiveColor ("Additive Color", Color) = (0,0,0,1)
        _EmmisionPower ("Emmision Power", Range(0, 10)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform float4 _MainColor;
            uniform sampler2D _MultiplyTexture; uniform float4 _MultiplyTexture_ST;
            uniform sampler2D _AdditiveTexture; uniform float4 _AdditiveTexture_ST;
            uniform float4 _AdditiveColor;
            uniform float _EmmisionPower;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
////// Emissive:
                float4 _AdditiveTexture_var = tex2D(_AdditiveTexture,TRANSFORM_TEX(i.uv2, _AdditiveTexture));
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(i.uv0, _MainTexture));
                float4 _MultiplyTexture_var = tex2D(_MultiplyTexture,TRANSFORM_TEX(i.uv1, _MultiplyTexture));
                float3 node_544 = (_MainTexture_var.rgb*_MainColor.rgb*_MultiplyTexture_var.rgb); // Diffuse Color
                float3 emissive = (((_AdditiveColor.rgb*_AdditiveTexture_var.rgb)*_EmmisionPower)+(node_544*UNITY_LIGHTMODEL_AMBIENT.rgb));
                float3 finalColor = emissive + (node_544*_LightColor0.rgb*attenuation);
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _MainTexture; uniform float4 _MainTexture_ST;
            uniform float4 _MainColor;
            uniform sampler2D _MultiplyTexture; uniform float4 _MultiplyTexture_ST;
            uniform sampler2D _AdditiveTexture; uniform float4 _AdditiveTexture_ST;
            uniform float4 _AdditiveColor;
            uniform float _EmmisionPower;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos(v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _MainTexture_var = tex2D(_MainTexture,TRANSFORM_TEX(i.uv0, _MainTexture));
                float4 _MultiplyTexture_var = tex2D(_MultiplyTexture,TRANSFORM_TEX(i.uv1, _MultiplyTexture));
                float3 node_544 = (_MainTexture_var.rgb*_MainColor.rgb*_MultiplyTexture_var.rgb); // Diffuse Color
                float3 finalColor = (node_544*_LightColor0.rgb*attenuation);
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
