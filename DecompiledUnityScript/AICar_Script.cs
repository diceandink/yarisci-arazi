using System;
using System.Collections;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class AICar_Script : MonoBehaviour
{
	public WheelCollider FrontLeftWheel;

	public WheelCollider FrontRightWheel;

	public float[] GearRatio;

	public int CurrentGear;

	public float EngineTorque;

	public float MaxEngineRPM;

	public float MinEngineRPM;

	private float EngineRPM;

	public GameObject waypointContainer;

	private UnityScript.Lang.Array waypoints;

	private int currentWaypoint;

	public static bool yarisBasla = false;

	private float inputSteer;

	private float inputTorque;

	public AICar_Script()
	{
		CurrentGear = 0;
		EngineTorque = 600f;
		MaxEngineRPM = 3000f;
		MinEngineRPM = 1000f;
		EngineRPM = 0f;
		currentWaypoint = 0;
		inputSteer = 0f;
		inputTorque = 0f;
	}

	public void yarisBaslat()
	{
		yarisBasla = true;
	}

	public void Start()
	{
		yarisBasla = false;
		float y = 1.5f * -1f;
		Vector3 centerOfMass = ((Component)this).rigidbody.centerOfMass;
		float num = (centerOfMass.y = y);
		Vector3 val2 = (((Component)this).rigidbody.centerOfMass = centerOfMass);
		GetWaypoints();
	}

	public void Update()
	{
		Rigidbody rigidbody = ((Component)this).rigidbody;
		Vector3 velocity = ((Component)this).rigidbody.velocity;
		rigidbody.drag = velocity.magnitude / 250f;
		if (!yarisBasla)
		{
			((Component)this).rigidbody.velocity = new Vector3(0f, 0f, 0f);
			((Component)this).rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
		}
		NavigateTowardsWaypoint();
		float num = (FrontLeftWheel.rpm + FrontRightWheel.rpm) / 2f;
		float[] gearRatio = GearRatio;
		EngineRPM = num * gearRatio[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio, CurrentGear)];
		ShiftGears();
		((Component)this).audio.pitch = Mathf.Abs(EngineRPM / MaxEngineRPM) + 1f;
		if (((Component)this).audio.pitch > 2f)
		{
			((Component)this).audio.pitch = 2f;
		}
		if (yarisBasla)
		{
			WheelCollider frontLeftWheel = FrontLeftWheel;
			float engineTorque = EngineTorque;
			float[] gearRatio2 = GearRatio;
			frontLeftWheel.motorTorque = engineTorque / gearRatio2[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio2, CurrentGear)] * inputTorque;
			WheelCollider frontRightWheel = FrontRightWheel;
			float engineTorque2 = EngineTorque;
			float[] gearRatio3 = GearRatio;
			frontRightWheel.motorTorque = engineTorque2 / gearRatio3[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio3, CurrentGear)] * inputTorque;
		}
		FrontLeftWheel.steerAngle = 10f * inputSteer;
		FrontRightWheel.steerAngle = 10f * inputSteer;
	}

	public void ShiftGears()
	{
		checked
		{
			int currentGear;
			if (!(EngineRPM < MaxEngineRPM))
			{
				currentGear = CurrentGear;
				for (int i = 0; i < ((GearRatio).Length); i++)
				{
					float rpm = FrontLeftWheel.rpm;
					float[] gearRatio = GearRatio;
					if (rpm * gearRatio[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio, i)] < MaxEngineRPM)
					{
						currentGear = i;
						break;
					}
				}
				CurrentGear = currentGear;
			}
			if (EngineRPM > MinEngineRPM)
			{
				return;
			}
			currentGear = CurrentGear;
			for (int num = ((GearRatio).Length) - 1; num >= 0; num--)
			{
				float rpm2 = FrontLeftWheel.rpm;
				float[] gearRatio2 = GearRatio;
				if (rpm2 * gearRatio2[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio2, num)] > MinEngineRPM)
				{
					currentGear = num;
					break;
				}
			}
			CurrentGear = currentGear;
		}
	}

	public void GetWaypoints()
	{
		UnityScript.Lang.Array val = new UnityScript.Lang.Array((System.Array)waypointContainer.GetComponentsInChildren(typeof(Transform)));
		waypoints = new UnityScript.Lang.Array();
		IEnumerator enumerator = UnityRuntimeServices.GetEnumerator((object)val);
		while (enumerator.MoveNext())
		{
			Transform val2 = (Transform)RuntimeServices.Coerce(enumerator.Current, typeof(Transform));
			if ((UnityEngine.Object)(object)val2 != (UnityEngine.Object)(object)waypointContainer.transform)
			{
				waypoints[waypoints.length] = val2;
				UnityRuntimeServices.Update(enumerator, (object)val2);
			}
		}
	}

	public void NavigateTowardsWaypoint()
	{
		Vector3 val = ((Component)this).transform.InverseTransformPoint(new Vector3(RuntimeServices.UnboxSingle(RuntimeServices.GetProperty(RuntimeServices.GetProperty(waypoints[currentWaypoint], "position"), "x")), ((Component)this).transform.position.y, RuntimeServices.UnboxSingle(RuntimeServices.GetProperty(RuntimeServices.GetProperty(waypoints[currentWaypoint], "position"), "z"))));
		inputSteer = val.x / val.magnitude;
		if (Mathf.Abs(inputSteer) < 0.5f)
		{
			inputTorque = val.z / val.magnitude - Mathf.Abs(inputSteer);
		}
		else
		{
			inputTorque = 0f;
		}
		checked
		{
			if (val.magnitude < 10f)
			{
				currentWaypoint++;
				if (currentWaypoint >= waypoints.length)
				{
					currentWaypoint = 0;
				}
			}
		}
	}

	public void Main()
	{
	}
}
