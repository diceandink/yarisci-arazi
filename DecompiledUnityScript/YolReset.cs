using System;
using UnityEngine;

[Serializable]
public class YolReset : MonoBehaviour
{
	public static Vector3 resetKordinat = new Vector3(0f, 0f, 0f);

	public static Quaternion resetRotation = new Quaternion(0f, 0f, 0f, 0f);

	public void OnTriggerEnter(Collider other)
	{
		if (((Component)other).CompareTag("Player"))
		{
			resetKordinat = kordinatAl();
			resetRotation = rotationAl();
		}
	}

	public Quaternion rotationAl()
	{
		return ((Component)this).transform.rotation;
	}

	public Vector3 kordinatAl()
	{
		return ((Component)this).transform.position;
	}

	public void Main()
	{
	}
}
