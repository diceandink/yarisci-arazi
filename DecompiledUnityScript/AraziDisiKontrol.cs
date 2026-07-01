using System;
using UnityEngine;

[Serializable]
public class AraziDisiKontrol : MonoBehaviour
{
	public float araziDisiSure;

	public int deneme;

	public AraziDisiKontrol()
	{
		araziDisiSure = -1f;
		deneme = 0;
	}

	public void OnTriggerEnter(Collider other)
	{
		if (((Component)other).CompareTag("arazidisi") && araziDisiSure == -1f)
		{
			araziDisiSure = Time.time;
		}
	}

	public void OnTriggerStay(Collider other)
	{
		if (((Component)other).CompareTag("arazidisi"))
		{
			if (araziDisiSure == -1f)
			{
				araziDisiSure = Time.time;
			}
			else if (Time.time - araziDisiSure > 3f)
			{
				MonoBehaviour.print((object)"geri don, geri don");
			}
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (((Component)other).CompareTag("arazidisi"))
		{
			araziDisiSure = -1f;
		}
	}

	public void Main()
	{
	}
}
