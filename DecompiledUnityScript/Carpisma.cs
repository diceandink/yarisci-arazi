using System;
using UnityEngine;

[Serializable]
public class Carpisma : MonoBehaviour
{
	public string parca;

	public static int carpmaSayi = 0;

	public PlayerCar_Script araba;

	public void Start()
	{
		araba = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
	}

	public void OnCollisionEnter(Collision collision)
	{
		checked
		{
			carpmaSayi++;
			Vector3 relativeVelocity = collision.relativeVelocity;
			if (relativeVelocity.magnitude > 0f)
			{
				MonoBehaviour.print((object)("hizli carpti: " + (object)carpmaSayi));
			}
		}
	}

	public void OnTriggerEnter(Collider other)
	{
		araba.Carpisma(parca);
	}

	public void Main()
	{
	}
}
