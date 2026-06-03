using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Camera-Control/Mouse Orbit")]
public class MouseOrbit : MonoBehaviour
{
	public Transform target;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public int yMinLimit;

	public int yMaxLimit;

	private float x;

	private float y;

	public MouseOrbit()
	{
		distance = 10f;
		xSpeed = 250f;
		ySpeed = 120f;
		yMinLimit = -20;
		yMaxLimit = 80;
		x = 0f;
		y = 0f;
	}

	public void Start()
	{
		Vector3 eulerAngles = ((Component)this).transform.eulerAngles;
		x = eulerAngles.y;
		y = eulerAngles.x;
		if (((UnityEngine.Object)(object)((Component)this).rigidbody) != null)
		{
			((Component)this).rigidbody.freezeRotation = true;
		}
	}

	public void LateUpdate()
	{
		if (((UnityEngine.Object)(object)target) != null)
		{
			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
			y = ClampAngle(y, yMinLimit, yMaxLimit);
			Quaternion val = Quaternion.Euler(y, x, 0f);
			Vector3 position = val * new Vector3(0f, 0f, distance * -1f) + target.position;
			((Component)this).transform.rotation = val;
			((Component)this).transform.position = position;
		}
	}

	public static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360f)
		{
			angle += 360f;
		}
		if (angle > 360f)
		{
			angle -= 360f;
		}
		return Mathf.Clamp(angle, min, max);
	}

	public void Main()
	{
	}
}
