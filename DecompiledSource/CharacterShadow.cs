using System;
using UnityEngine;

public class CharacterShadow : MonoBehaviour
{
	public GameObject target;

	public float castingDistance = 10f;

	public float lightness = 0.3f;

	public int textureSize = 256;

	public Texture fadeoutTexture;

	private RenderTexture shadowmap;

	private GameObject child;

	private int savedPixelLightCount;

	private int oldTargetLayer;

	private int targetLayer;

	private static int privateLayer = 31;

	private static string shadowMatString = "Shader \"Hidden/ShadowMat\" {\n\tProperties {\n\t\t_Color (\"Color\", Color) = (0,0,0,0)\n\t}\n\tSubShader {\n\t\tPass {\n\t\t\tZTest Greater Cull Off ZWrite Off\n\t\t\tColor [_Color]\n\t\t\tSetTexture [_Dummy] { combine primary }\n\t\t}\n\t}\n\tFallback off\n}";

	private Material m_ShadowMaterial;

	private static string projectorMatString = "\tShader \"Hidden/ShadowProjectorMultiply\" { \n\tProperties {\n\t\t_ShadowTex (\"Cookie\", 2D) = \"white\" { TexGen ObjectLinear }\n\t\t_FalloffTex (\"FallOff\", 2D) = \"white\" { TexGen ObjectLinear\t}\n\t}\n\tSubshader {\n\t\tPass {\n\t\t\tZWrite off\n\t\t\tOffset -1, -1\n\t\t\tFog { Color (1, 1, 1) }\n\t\t\tAlphaTest Greater 0\n\t\t\tColorMask RGB\n\t\t\tBlend DstColor Zero\n\t\t\tSetTexture [_ShadowTex] {\n\t\t\t\tcombine texture, ONE - texture\n\t\t\t\tMatrix [_Projector]\n\t\t\t}\n\t\t\tSetTexture [_FalloffTex] {\n\t\t\t\tconstantColor (1,1,1,0)\n\t\t\t\tcombine previous lerp (texture) constant\n\t\t\t\tMatrix [_ProjectorClip]\n\t\t\t}\n\t\t}\n\t}\n}";

	private Material m_ProjectorMaterial;

	private Material shadowMaterial
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			if ((Object)(object)m_ShadowMaterial == (Object)null)
			{
				m_ShadowMaterial = new Material(shadowMatString);
				((Object)m_ShadowMaterial.shader).hideFlags = (HideFlags)13;
				((Object)m_ShadowMaterial).hideFlags = (HideFlags)13;
			}
			return m_ShadowMaterial;
		}
	}

	private Material projectorMaterial
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			if ((Object)(object)m_ProjectorMaterial == (Object)null)
			{
				m_ProjectorMaterial = new Material(projectorMatString);
				((Object)m_ProjectorMaterial.shader).hideFlags = (HideFlags)13;
				((Object)m_ProjectorMaterial).hideFlags = (HideFlags)13;
			}
			return m_ProjectorMaterial;
		}
	}

	private void Start()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)target))
		{
			Debug.Log((object)"No target assigned! Disabling CharacterShadow script");
			((Behaviour)this).enabled = false;
			return;
		}
		targetLayer = target.layer;
		if (targetLayer == 0)
		{
			Debug.Log((object)"Warning: target object should use a separate layer");
		}
		child = new GameObject("ChildCamProjector", new Type[3]
		{
			typeof(Camera),
			typeof(Projector),
			typeof(CharacterShadowHelper)
		});
		child.camera.clearFlags = (CameraClearFlags)2;
		child.camera.backgroundColor = Color.white;
		child.camera.cullingMask = 1 << privateLayer;
		child.camera.isOrthoGraphic = true;
		Projector val = (Projector)child.GetComponent(typeof(Projector));
		val.isOrthoGraphic = true;
		val.ignoreLayers = 1 << targetLayer;
		val.material = projectorMaterial;
		val.material.SetTexture("_FalloffTex", fadeoutTexture);
		child.transform.parent = ((Component)this).transform;
		child.transform.localPosition = Vector3.zero;
		child.transform.localRotation = Quaternion.identity;
	}

	private void LateUpdate()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (!Object.op_Implicit((Object)(object)shadowmap))
		{
			shadowmap = new RenderTexture(textureSize, textureSize, 16);
			shadowmap.isPowerOfTwo = true;
			child.camera.targetTexture = shadowmap;
			Projector val = (Projector)child.GetComponent(typeof(Projector));
			val.material.SetTexture("_ShadowTex", (Texture)(object)shadowmap);
		}
		OrientToEncloseTarget();
	}

	private void OnDisable()
	{
		Object.Destroy((Object)(object)shadowmap);
		shadowmap = null;
	}

	private static void SetLayerRecursive(Transform tr, int layer, int whereLayer)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		GameObject gameObject = ((Component)tr).gameObject;
		if (gameObject.layer == whereLayer)
		{
			gameObject.layer = layer;
		}
		foreach (Transform item in tr)
		{
			Transform tr2 = item;
			SetLayerRecursive(tr2, layer, whereLayer);
		}
	}

	public void OnPreCull()
	{
		savedPixelLightCount = QualitySettings.pixelLightCount;
		oldTargetLayer = target.layer;
		SetLayerRecursive(target.transform, privateLayer, oldTargetLayer);
	}

	public void OnPostRender()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		SetLayerRecursive(target.transform, oldTargetLayer, privateLayer);
		Material obj = shadowMaterial;
		Color color = default(Color);
		((Color)(ref color))._002Ector(lightness, lightness, lightness, lightness);
		obj.color = color;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < shadowMaterial.passCount; i++)
		{
			shadowMaterial.SetPass(i);
			GL.Begin(7);
			GL.TexCoord2(0f, 0f);
			GL.Vertex3(0f, 0f, -99.99f);
			GL.TexCoord2(1f, 0f);
			GL.Vertex3(1f, 0f, -99.99f);
			GL.TexCoord2(1f, 1f);
			GL.Vertex3(1f, 1f, -99.99f);
			GL.TexCoord2(0f, 1f);
			GL.Vertex3(0f, 1f, -99.99f);
			GL.End();
		}
		GL.PopMatrix();
		QualitySettings.pixelLightCount = savedPixelLightCount;
	}

	private void OrientToEncloseTarget()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = target.transform.position;
		float num = 5f;
		if (Object.op_Implicit((Object)(object)target.renderer))
		{
			Bounds bounds = target.renderer.bounds;
			val = ((Bounds)(ref bounds)).center;
			Vector3 extents = ((Bounds)(ref bounds)).extents;
			num = ((Vector3)(ref extents)).magnitude;
		}
		num *= 5.05f;
		Vector3 val2 = val - ((Component)this).transform.position;
		float magnitude = ((Vector3)(ref val2)).magnitude;
		child.transform.LookAt(val);
		child.camera.orthographicSize = num;
		child.camera.nearClipPlane = magnitude - num;
		child.camera.farClipPlane = magnitude + num;
		Projector val3 = (Projector)child.GetComponent(typeof(Projector));
		val3.orthoGraphicSize = num;
		val3.nearClipPlane = magnitude;
		val3.farClipPlane = magnitude + castingDistance;
		val3.material.SetTexture("_ShadowTex", (Texture)(object)shadowmap);
	}
}
