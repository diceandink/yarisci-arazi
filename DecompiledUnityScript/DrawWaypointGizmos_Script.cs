using System;
using System.Collections;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class DrawWaypointGizmos_Script : MonoBehaviour
{
	public void OnDrawGizmos()
	{
		object componentsInChildren = ((Component)this).gameObject.GetComponentsInChildren(typeof(Transform));
		IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(componentsInChildren);
		while (enumerator.MoveNext())
		{
			Transform val = (Transform)RuntimeServices.Coerce(enumerator.Current, typeof(Transform));
			Gizmos.DrawSphere(val.position, 1f);
			UnityRuntimeServices.Update(enumerator, (object)val);
		}
	}

	public void Main()
	{
	}
}
