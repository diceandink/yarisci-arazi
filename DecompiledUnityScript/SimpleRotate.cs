using System;
using UnityEngine;

[Serializable]
public class SimpleRotate : MonoBehaviour
{
	public Vector3 speed;

	public SimpleRotate()
	{
		speed = new Vector3(20f, 15f, 5f);
	}

	public void Update()
	{
		((Component)this).transform.localEulerAngles = speed * Time.time;
	}

	public void Main()
	{
	}
}
