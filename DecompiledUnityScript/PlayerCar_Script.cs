using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class PlayerCar_Script : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class turboPasif_002443 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MotionBlur _0024blur_0024287;

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					return base.Yield(2, new WaitForSeconds(2f));
				case 2:
					turboAktif = false;
					_0024blur_0024287 = (MotionBlur)UnityEngine.Object.FindObjectOfType(typeof(MotionBlur));
					_0024blur_0024287.blurAmount = 0f;
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024();
		}
	}

	private float tersSure;

	public double eskiHiz;

	public double yeniHiz;

	public WheelCollider FrontLeftWheel;

	public WheelCollider FrontRightWheel;

	public float[] GearRatio;

	public int CurrentGear;

	public static int secilenAraba = 1;

	public static bool turboAktif = false;

	public float EngineTorque;

	public float MaxEngineRPM;

	public float MinEngineRPM;

	private float EngineRPM;

	public GameObject arazikup;

	public AracCalisma aracSes;

	public kadranHiz cevirme;

	public GameObject araba;

	public YolReset resetYer;

	public yarisSonuc sonucGoster;

	public SmoothFollow son;

	public soruEkrani yarisS;

	public ekranGoruntuleri yarisCikis;

	public bool oyunSonuSoru;

	public bool yarisBasla;

	public bool oyunPauseDurum;

	public bool durdur;

	public int durdurSayi;

	public bool arabaGitmesin;

	public PlayerCar_Script()
	{
		tersSure = -1f;
		eskiHiz = 0.0;
		yeniHiz = 0.0;
		CurrentGear = 0;
		EngineTorque = 600f;
		MaxEngineRPM = 3000f;
		MinEngineRPM = 1000f;
		EngineRPM = 0f;
		oyunSonuSoru = false;
		yarisBasla = false;
		oyunPauseDurum = false;
		durdur = false;
		durdurSayi = 4;
		arabaGitmesin = true;
	}

	public void Start()
	{
		int num = -1;
		Vector3 centerOfMass = ((Component)this).rigidbody.centerOfMass;
		float num2 = (centerOfMass.y = num);
		Vector3 val2 = (((Component)this).rigidbody.centerOfMass = centerOfMass);
		oyunSonuSoru = false;
		aracSes = (AracCalisma)(object)UnityEngine.Object.FindObjectOfType(typeof(AracCalisma));
		arazikup = GameObject.Find("arazi_kup");
		cevirme = (kadranHiz)(object)UnityEngine.Object.FindObjectOfType(typeof(kadranHiz));
		araba = GameObject.FindWithTag("playercar");
		resetYer = (YolReset)(object)UnityEngine.Object.FindObjectOfType(typeof(YolReset));
		sonucGoster = (yarisSonuc)(object)UnityEngine.Object.FindObjectOfType(typeof(yarisSonuc));
		son = (SmoothFollow)(object)UnityEngine.Object.FindObjectOfType(typeof(SmoothFollow));
		yarisS = (soruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(soruEkrani));
		yarisCikis = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
	}

	public void yarisBaslat()
	{
		yarisBasla = true;
	}

	public void Carpisma(string yon)
	{
		if (secilenAraba == 4)
		{
			switch (yon)
			{
			case "sol":
			{
				GameObject val9 = GameObject.Find("araba_sol");
				GameObject val10 = GameObject.Find("araba_sol_def");
				val9.renderer.enabled = false;
				val10.renderer.enabled = true;
				break;
			}
			case "sag":
			{
				GameObject val7 = GameObject.Find("araba_sag");
				GameObject val8 = GameObject.Find("araba_sag_def");
				val7.renderer.enabled = false;
				val8.renderer.enabled = true;
				break;
			}
			case "arka":
			{
				GameObject val5 = GameObject.Find("araba_arka");
				GameObject val6 = GameObject.Find("araba_arka_def");
				val5.renderer.enabled = false;
				val6.renderer.enabled = true;
				break;
			}
			case "kaput":
			{
				GameObject val3 = GameObject.Find("araba_kaput");
				GameObject val4 = GameObject.Find("araba_kaput_def");
				val3.renderer.enabled = false;
				val4.renderer.enabled = true;
				break;
			}
			case "ust":
			{
				GameObject val = GameObject.Find("araba_ust");
				GameObject val2 = GameObject.Find("araba_ust_def");
				val.renderer.enabled = false;
				val2.renderer.enabled = true;
				break;
			}
			}
		}
		else if (secilenAraba == 1)
		{
			switch (yon)
			{
			case "sol":
			{
				GameObject val17 = GameObject.Find("araba_sol_on2");
				GameObject val18 = GameObject.Find("araba_sol_arka2");
				GameObject val19 = GameObject.Find("araba_sol_on_def2");
				GameObject val20 = GameObject.Find("araba_sol_arka_def2");
				val17.renderer.enabled = false;
				val19.renderer.enabled = true;
				val18.renderer.enabled = false;
				val20.renderer.enabled = true;
				break;
			}
			case "sag":
			{
				GameObject val13 = GameObject.Find("araba_sag_on2");
				GameObject val14 = GameObject.Find("araba_sag_arka2");
				GameObject val15 = GameObject.Find("araba_sag_on_def2");
				GameObject val16 = GameObject.Find("araba_sag_arka_def2");
				val13.renderer.enabled = false;
				val15.renderer.enabled = true;
				val14.renderer.enabled = false;
				val16.renderer.enabled = true;
				break;
			}
			case "ust":
			{
				GameObject val11 = GameObject.Find("araba_ust2");
				GameObject val12 = GameObject.Find("araba_ust_def2");
				val11.renderer.enabled = false;
				val12.renderer.enabled = true;
				break;
			}
			}
		}
		else if (secilenAraba == 3)
		{
			switch (yon)
			{
			case "sol":
			{
				GameObject val25 = GameObject.Find("araba_sol3");
				GameObject val26 = GameObject.Find("araba_sol_def3");
				val25.renderer.enabled = false;
				val26.renderer.enabled = true;
				break;
			}
			case "sag":
			{
				GameObject val23 = GameObject.Find("araba_sag3");
				GameObject val24 = GameObject.Find("araba_sag_def3");
				val23.renderer.enabled = false;
				val24.renderer.enabled = true;
				break;
			}
			case "arka":
			{
				GameObject val21 = GameObject.Find("araba_arka_3");
				GameObject val22 = GameObject.Find("araba_arka_def_3");
				val21.renderer.enabled = false;
				val22.renderer.enabled = true;
				break;
			}
			}
		}
		else if (secilenAraba == 2)
		{
			switch (yon)
			{
			case "kaput":
			{
				GameObject val33 = GameObject.Find("araba_on4");
				GameObject val34 = GameObject.Find("araba_on_def4");
				GameObject val35 = GameObject.Find("araba_kaput4");
				GameObject val36 = GameObject.Find("araba_kaput_def4");
				break;
			}
			case "sol":
			{
				GameObject val31 = GameObject.Find("araba_sol_arka4");
				GameObject val32 = GameObject.Find("araba_sol_arka_def4");
				val31.renderer.enabled = false;
				val32.renderer.enabled = true;
				break;
			}
			case "sag":
			{
				GameObject val29 = GameObject.Find("araba_sag_arka4");
				GameObject val30 = GameObject.Find("araba_sag_arka_def4");
				val29.renderer.enabled = false;
				val30.renderer.enabled = true;
				break;
			}
			case "ust":
			{
				GameObject val27 = GameObject.Find("araba_ust4");
				GameObject val28 = GameObject.Find("araba_ust_def4");
				val27.renderer.enabled = false;
				val28.renderer.enabled = true;
				break;
			}
			}
		}
	}

	public void OyunDondur(float deger)
	{
		Time.timeScale = deger;
		oyunPauseDurum = true;
	}

	public void OyunDevam()
	{
		Time.timeScale = 1f;
		oyunPauseDurum = false;
	}

	public IEnumerator turboPasif()
	{
		return new turboPasif_002443().GetEnumerator();
	}

	public void sesAyarla()
	{
		AracCalisma aracCalisma = aracSes;
		Vector3 velocity = ((Component)this).rigidbody.velocity;
		aracCalisma.sesAyarla(velocity.magnitude);
	}

	public void Update()
	{
		kadranHiz obj = cevirme;
		Vector3 velocity2 = ((Component)this).rigidbody.velocity;
		obj.kadranAyarla(velocity2.magnitude, 60f);
		if (Input.GetKeyDown("r"))
		{
			arabaReset();
		}
		if (Input.GetKeyUp("p"))
		{
			if (!oyunPauseDurum)
			{
				OyunDondur(0f);
			}
			else
			{
				OyunDevam();
			}
		}
		sesAyarla();
	}

	public void FixedUpdate()
	{
		if (!yarisBasla)
		{
			((Component)this).rigidbody.velocity = new Vector3(0f, 0f, 0f);
			((Component)this).rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
		}
		Rigidbody rigidbody = ((Component)this).rigidbody;
		Vector3 velocity = ((Component)this).rigidbody.velocity;
		rigidbody.drag = velocity.magnitude / 250f;
		float num = (FrontLeftWheel.rpm + FrontRightWheel.rpm) / 2f;
		float[] gearRatio = GearRatio;
		EngineRPM = num * gearRatio[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio, CurrentGear)];
		ShiftGears();
		if (yarisBasla)
		{
			if (turboAktif)
			{
				WheelCollider frontLeftWheel = FrontLeftWheel;
				float engineTorque = EngineTorque;
				float[] gearRatio2 = GearRatio;
				frontLeftWheel.motorTorque = engineTorque / gearRatio2[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio2, CurrentGear)] * Input.GetAxis("Vertical") * 4f;
				WheelCollider frontRightWheel = FrontRightWheel;
				float engineTorque2 = EngineTorque;
				float[] gearRatio3 = GearRatio;
				frontRightWheel.motorTorque = engineTorque2 / gearRatio3[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio3, CurrentGear)] * Input.GetAxis("Vertical") * 4f;
				((MonoBehaviour)this).StartCoroutine_Auto(turboPasif());
			}
			else if (Input.GetAxis("Vertical") > 0f)
			{
				WheelCollider frontLeftWheel2 = FrontLeftWheel;
				float engineTorque3 = EngineTorque;
				float[] gearRatio4 = GearRatio;
				frontLeftWheel2.motorTorque = engineTorque3 / gearRatio4[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio4, CurrentGear)] * Input.GetAxis("Vertical") * (float)durdurSayi;
				WheelCollider frontRightWheel2 = FrontRightWheel;
				float engineTorque4 = EngineTorque;
				float[] gearRatio5 = GearRatio;
				frontRightWheel2.motorTorque = engineTorque4 / gearRatio5[RuntimeServices.NormalizeArrayIndex((System.Array)gearRatio5, CurrentGear)] * Input.GetAxis("Vertical") * (float)durdurSayi;
			}
			else
			{
				FrontLeftWheel.motorTorque = 200f * Input.GetAxis("Vertical");
				FrontRightWheel.motorTorque = 200f * Input.GetAxis("Vertical");
			}
		}
		if (Input.GetAxis("Jump") != 0f)
		{
			arabaFren();
		}
		if (durdur)
		{
			durdurSayi = 0;
			if (EngineRPM > 0f)
			{
				FrontLeftWheel.motorTorque = EngineTorque * -1f;
				FrontRightWheel.motorTorque = EngineTorque * -1f;
			}
			else
			{
				EngineTorque = 0f;
				MaxEngineRPM = 0f;
				MinEngineRPM = 0f;
				son.oyunSonu();
				yarisS.soruBasi = false;
				if (!oyunSonuSoru)
				{
					sonucGoster.kontrol();
					oyunSonuSoru = true;
					sonucGoster.sonucGoster = true;
					ekranGoruntuleri.videoShow = true;
				}
				OyunDondur(0.0001f);
			}
		}
		donusAyarla();
		FrontLeftWheel.steerAngle = 25f * Input.GetAxis("Horizontal");
		FrontRightWheel.steerAngle = 25f * Input.GetAxis("Horizontal");
	}

	public void donusAyarla()
	{
		Vector3 velocity = ((Component)this).rigidbody.velocity;
		float magnitude = velocity.magnitude;
		float num = default(float);
		num = ((magnitude < 20f) ? (magnitude * magnitude / 250f) : ((!(magnitude < 50f)) ? (magnitude * magnitude / 250f) : (magnitude * magnitude / 250f)));
		((Component)this).rigidbody.angularDrag = num;
	}

	public void arabaFren()
	{
		if (EngineRPM > -10f)
		{
			FrontLeftWheel.motorTorque = EngineTorque * -1f;
			FrontRightWheel.motorTorque = EngineTorque * -1f;
		}
		else if (EngineRPM < -10f)
		{
			FrontLeftWheel.motorTorque = EngineTorque;
			FrontRightWheel.motorTorque = EngineTorque;
		}
	}

	public void arabaReset()
	{
		((Component)this).transform.position = YolReset.resetKordinat;
		((Component)this).transform.rotation = YolReset.resetRotation;
		((Component)this).rigidbody.velocity = new Vector3(0f, 0f, 0f);
		((Component)this).rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
	}

	public void arabaDurdur()
	{
		durdur = true;
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

	public void Main()
	{
	}
}
