using System;
using UnityEngine;

[Serializable]
public class SoruTopla : MonoBehaviour
{
	public static int soruSayisi = 0;

	public void Start()
	{
		soruSayisi = 0;
	}

	public void OnTriggerEnter(Collider other)
	{
		checked
		{
			if (((Component)other).CompareTag("Player"))
			{
				UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)this).gameObject);
				soruSayisi++;
			}
		}
	}

	public void Main()
	{
	}
}
