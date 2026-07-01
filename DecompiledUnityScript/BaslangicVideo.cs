using System;
using UnityEngine;

[Serializable]
public class BaslangicVideo : MonoBehaviour
{
	public MovieTexture baslangicMovie;

	public AudioSource baslangicAudio;

	public void Awake()
	{
		baslangicMovie.Play();
		baslangicAudio.Play();
	}

	public void Update()
	{
		if (Input.GetKeyUp((KeyCode)13))
		{
			Application.LoadLevel("K_Giris");
		}
	}

	public void OnGUI()
	{
		GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), (Texture)(object)baslangicMovie);
		if (!baslangicMovie.isPlaying && Application.CanStreamedLevelBeLoaded("K_Giris"))
		{
			Application.LoadLevel("K_Giris");
		}
	}

	public void Main()
	{
	}
}
