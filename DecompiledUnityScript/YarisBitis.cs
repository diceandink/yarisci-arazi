using System;
using UnityEngine;

[Serializable]
public class YarisBitis : MonoBehaviour
{
	private bool yarisBitti;

	public void OnStart()
	{
		yarisBitti = false;
	}

	public void OnTriggerEnter(Collider other)
	{
		if (((Component)other).CompareTag("Player"))
		{
			yarisBitti = true;
			ekranGoruntuleri ekranGoruntuleri2 = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
			ekranGoruntuleri2.suregoster = false;
			PlayerCar_Script playerCar_Script = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
			playerCar_Script.arabaDurdur();
		}
	}

	public bool getYarisBitti()
	{
		return yarisBitti;
	}

	public void Main()
	{
	}
}
