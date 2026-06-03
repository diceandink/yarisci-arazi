using System;
using UnityEngine;

[Serializable]
public class HaritaAraba : MonoBehaviour
{
	public double uzunlukX;

	public HaritaAraba()
	{
		uzunlukX = 0.699999988079071;
	}

	public void arabaKonum(double x, double z, double maxX)
	{
		double num = uzunlukX / maxX;
		double num2 = x * num;
		double num3 = z * num - 0.46000000834465027;
		GameObject val = GameObject.FindWithTag("harita");
		double num4 = num2;
		Vector3 position = val.transform.position;
		float num5 = (position.z = (float)num4);
		Vector3 val3 = (val.transform.position = position);
		double num6 = num3;
		Vector3 position2 = val.transform.position;
		float num7 = (position2.x = (float)num6);
		Vector3 val5 = (val.transform.position = position2);
	}

	public void Main()
	{
	}
}
