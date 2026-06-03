using System;
using UnityEngine;

[Serializable]
public class PuanToplama : MonoBehaviour
{
	public static int hediyeSayisi;

	public int saatTip;

	public PuanSes ses;

	public void Start()
	{
		hediyeSayisi = 0;
		ses = (PuanSes)(object)UnityEngine.Object.FindObjectOfType(typeof(PuanSes));
	}

	public void OnTriggerEnter(Collider other)
	{
		checked
		{
			if (((Component)other).CompareTag("Player"))
			{
				UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)this).gameObject);
				ses.sesCal();
				switch (saatTip)
				{
				case 1:
					hediyeSayisi++;
					break;
				case 2:
					hediyeSayisi += 2;
					break;
				case 3:
					hediyeSayisi += 3;
					break;
				}
			}
		}
	}

	public void Main()
	{
	}
}
