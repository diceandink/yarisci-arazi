using System;
using UnityEngine;

[Serializable]
public class kadranHiz : MonoBehaviour
{
	public float eskiHiz;

	public kadranHiz()
	{
		eskiHiz = 0f;
	}

	public void kadranAyarla(float hiz, float maxHiz)
	{
		float num = default(float);
		num = ((hiz > maxHiz) ? maxHiz : ((!(hiz < 0f)) ? hiz : 0f));
		float num2 = num - eskiHiz;
		eskiHiz = num;
		float num3 = num2 / maxHiz;
		((Component)this).transform.Rotate(0f, num3 * 270f, 0f);
	}

	public void Main()
	{
	}
}
