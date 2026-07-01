using System;
using UnityEngine;

[Serializable]
public class WheelAlignment_Script : MonoBehaviour
{
	public WheelCollider CorrespondingCollider;

	public GameObject SlipPrefab;

	private float RotationValue;

	public WheelAlignment_Script()
	{
		RotationValue = 0f;
	}

	public void Update()
	{
		RaycastHit val = default(RaycastHit);
		Vector3 val2 = ((Component)CorrespondingCollider).transform.TransformPoint(CorrespondingCollider.center);
		if (Physics.Raycast(val2, -((Component)CorrespondingCollider).transform.up, out val, CorrespondingCollider.suspensionDistance + CorrespondingCollider.radius))
		{
			((Component)this).transform.position = val.point + ((Component)CorrespondingCollider).transform.up * CorrespondingCollider.radius;
		}
		else
		{
			((Component)this).transform.position = val2 - ((Component)CorrespondingCollider).transform.up * CorrespondingCollider.suspensionDistance;
		}
		((Component)this).transform.rotation = ((Component)CorrespondingCollider).transform.rotation * Quaternion.Euler(RotationValue, CorrespondingCollider.steerAngle, 0f);
		RotationValue += CorrespondingCollider.rpm * 6f * Time.deltaTime;
		WheelHit val3 = default(WheelHit);
		CorrespondingCollider.GetGroundHit(out val3);
		if (Mathf.Abs(val3.sidewaysSlip) > 2f && (((UnityEngine.Object)(object)SlipPrefab) != null))
		{
			UnityEngine.Object.Instantiate((UnityEngine.Object)(object)SlipPrefab, val3.point, Quaternion.identity);
		}
	}

	public void Main()
	{
	}
}
