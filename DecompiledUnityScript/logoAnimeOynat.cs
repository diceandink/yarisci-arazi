using System;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class logoAnimeOynat : MonoBehaviour
{
	public void Main()
	{
		UnityRuntimeServices.Invoke((object)((Component)this).renderer.material.mainTexture, "Play", new object[0], typeof(MonoBehaviour));
	}
}
