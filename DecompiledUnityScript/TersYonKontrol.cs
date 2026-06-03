using System;
using UnityEngine;

[Serializable]
public class TersYonKontrol : MonoBehaviour
{
	public static int tersSayi = 0;

	public Transform bulunduguTransform;

	public Transform[] ileriKontrol;

	public static Transform kullanilanNokta;

	private float tersSure;

	private float tersLimit;

	public static Transform onCollider;

	public static Transform arkaCollider;

	public ekranGoruntuleri ekranGoruntu;

	public TersYonKontrol()
	{
		tersSure = -1f;
		tersLimit = 3f;
	}

	public void Start()
	{
		ekranGoruntu = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
	}

	public void uyariKaldir()
	{
		ekranGoruntu.tersYonUyari = false;
	}

	public void uyariGoster()
	{
		ekranGoruntu.tersYonUyari = true;
	}

	public void colliderAyarla(Transform onC, Transform arkaC)
	{
		onCollider = onC;
		arkaCollider = arkaC;
	}

	public void Update()
	{
		if ((UnityEngine.Object)(object)kullanilanNokta == (UnityEngine.Object)(object)bulunduguTransform)
		{
			bool flag = tersKontrol();
			if (flag && tersSure != -1f)
			{
				if (Time.time - tersSure > tersLimit)
				{
					uyariGoster();
				}
			}
			else if (flag && tersSure == -1f)
			{
				tersSure = Time.time;
			}
			else
			{
				arabaDuz();
			}
		}
		if (Input.GetKeyUp("h"))
		{
			arabaDuz();
		}
	}

	public void arabaDuz()
	{
		tersSure = -1f;
		uyariKaldir();
	}

	public bool tersKontrol()
	{
		bool result = true;
		int i = 0;
		Transform[] array = ileriKontrol;
		checked
		{
			for (int length = array.Length; i < length; i++)
			{
				int num = (int)onCollider.position.x;
				int num2 = (int)onCollider.position.y;
				int num3 = (int)onCollider.position.z;
				int num4 = (int)arkaCollider.position.x;
				int num5 = (int)arkaCollider.position.y;
				int num6 = (int)arkaCollider.position.z;
				int num7 = (int)array[i].position.x;
				int num8 = (int)array[i].position.y;
				int num9 = (int)array[i].position.z;
				Vector3 val = new Vector3((float)(num - num7), (float)(num2 - num8), (float)(num3 - num9));
				Vector3 val2 = new Vector3((float)(num4 - num7), (float)(num5 - num8), (float)(num6 - num9));
				if (val2.magnitude > val.magnitude)
				{
					result = false;
					break;
				}
				tersSayi++;
			}
			return result;
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (((Component)other).CompareTag("Player"))
		{
			kullanilanNokta = bulunduguTransform;
		}
	}

	public void Main()
	{
	}
}
