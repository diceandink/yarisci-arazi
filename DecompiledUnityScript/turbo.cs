using System;
using UnityEngine;

[Serializable]
public class turbo : MonoBehaviour
{
	public PlayerCar_Script turboAktifEt;

	public MotionBlur blur;

	public void Start()
	{
		turboAktifEt = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
		blur = (MotionBlur)UnityEngine.Object.FindObjectOfType(typeof(MotionBlur));
	}

	public void OnTriggerEnter(Collider other)
	{
		if (((Component)other).CompareTag("Player"))
		{
			UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)this).gameObject);
			blur.blurAmount = 0.6f;
			PlayerCar_Script.turboAktif = true;
		}
	}

	public void Main()
	{
	}
}
