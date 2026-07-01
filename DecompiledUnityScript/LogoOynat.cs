using System;
using UnityEngine;

[Serializable]
public class LogoOynat : MonoBehaviour
{
	public MovieTexture logoMovie;

	public AudioSource logoAudio;

	public void Start()
	{
		logoMovie.Play();
		logoAudio.Play();
	}

	public void OnGUI()
	{
		GUI.DrawTexture(new Rect(0f, 0f, (float)Screen.width, (float)Screen.height), (Texture)(object)logoMovie);
		if (!logoMovie.isPlaying && Application.CanStreamedLevelBeLoaded("K_Giris"))
		{
			Application.LoadLevel("K_Giris");
		}
	}

	public void Main()
	{
	}
}
