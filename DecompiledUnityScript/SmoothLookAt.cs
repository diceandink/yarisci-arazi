using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Camera-Control/Smooth Look At")]
public class SmoothLookAt : MonoBehaviour
{
	public Transform target;

	public float damping;

	public bool smooth;

	public SmoothLookAt()
	{
		damping = 6f;
		smooth = true;
	}

	public void LateUpdate()
	{
		if ((((UnityEngine.Object)(object)target) != null))
		{
			if (smooth)
			{
				Quaternion val = Quaternion.LookRotation(target.position - ((Component)this).transform.position);
				((Component)this).transform.rotation = Quaternion.Slerp(((Component)this).transform.rotation, val, Time.deltaTime * damping);
			}
			else
			{
				((Component)this).transform.LookAt(target);
			}
		}
	}

	public void Start()
	{
		if (((UnityEngine.Object)(object)((Component)this).rigidbody) != null)
		{
			((Component)this).rigidbody.freezeRotation = true;
		}
	}

	public void Main()
	{
	}
}
