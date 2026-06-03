using System;
using UnityEngine;

[Serializable]
public class ArabaDurma : MonoBehaviour
{
	public void OnTriggerEnter(Collider other)
	{
		if (((Component)other).CompareTag("Player"))
		{
			PlayerCar_Script playerCar_Script = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
			playerCar_Script.arabaDurdur();
		}
	}

	public void Main()
	{
	}
}
