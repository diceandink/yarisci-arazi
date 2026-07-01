using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Camera-Control/Smooth Follow")]
public class SmoothFollow : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float height;

	public float heightDamping;

	public float rotationDamping;

	public bool son;

	public SmoothFollow()
	{
		distance = 10f;
		height = 5f;
		heightDamping = 2f;
		rotationDamping = 3f;
		son = true;
	}

	public void oyunSonu()
	{
		son = true;
	}

	public void LateUpdate()
	{
		if ((((UnityEngine.Object)(object)target) != null))
		{
			float y = target.eulerAngles.y;
			float num = target.position.y + height;
			float y2 = ((Component)this).transform.eulerAngles.y;
			float y3 = ((Component)this).transform.position.y;
			y2 = ((!(!son)) ? Mathf.LerpAngle(y2 + 30f * Time.deltaTime, y, rotationDamping * Time.deltaTime) : Mathf.LerpAngle(y2, y, rotationDamping * Time.deltaTime));
			y3 = ((!(!son)) ? Mathf.Lerp(y3, num, heightDamping * Time.deltaTime) : Mathf.Lerp(y3, num, heightDamping * Time.deltaTime));
			Quaternion val = Quaternion.Euler(0f, y2, 0f);
			((Component)this).transform.position = target.position;
			((Component)this).transform.position = ((Component)this).transform.position - val * Vector3.forward * distance;
			float y4 = y3;
			Vector3 position = ((Component)this).transform.position;
			float num2 = (position.y = y4);
			Vector3 val3 = (((Component)this).transform.position = position);
			((Component)this).transform.LookAt(target);
		}
	}

	public void Main()
	{
	}
}
