using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class ekranGoruntuleri : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class basaDon_002433 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					return base.Yield(2, new WaitForSeconds(0.002f));
				case 2:
					Application.LoadLevel("OyunMenu");
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

	[Serializable]
	[CompilerGenerated]
	internal sealed class geriSaydir_002435 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ekranGoruntuleri _0024self_300;

			public _0024(ekranGoruntuleri self_)
			{
				_0024self_300 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024self_300.geriSar = 1;
					return base.Yield(2, new WaitForSeconds(1f));
				case 2:
					_0024self_300.geriSar = 2;
					return base.Yield(3, new WaitForSeconds(1f));
				case 3:
					_0024self_300.geriSar = 3;
					return base.Yield(4, new WaitForSeconds(1f));
				case 4:
					_0024self_300.geriSar = 0;
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal ekranGoruntuleri _0024self_301;

		public geriSaydir_002435(ekranGoruntuleri self_)
		{
			_0024self_301 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_301);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class oyunBaslat_002437 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal soruEkrani _0024sorulariSil_0024302;

			internal PlayerCar_Script _0024oyunBaslat_0024303;

			internal AICar_Script _0024oyunAIBaslat_0024304;

			internal ekranGoruntuleri _0024self_305;

			public _0024(ekranGoruntuleri self_)
			{
				_0024self_305 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024sorulariSil_0024302 = (soruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(soruEkrani));
					_0024sorulariSil_0024302.soruAc = false;
					_0024self_305.soruSec = false;
					((MonoBehaviour)_0024self_305).StartCoroutine_Auto(_0024self_305.geriSaydir());
					return base.Yield(2, new WaitForSeconds(3.2f));
				case 2:
					_0024self_305.logoAc = false;
					_0024self_305.aracSecimGoster = false;
					_0024oyunBaslat_0024303 = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
					_0024oyunBaslat_0024303.yarisBaslat();
					_0024oyunAIBaslat_0024304 = (AICar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(AICar_Script));
					_0024oyunAIBaslat_0024304.yarisBaslat();
					_0024self_305.sureBaslat();
					_0024self_305.suregoster = true;
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal ekranGoruntuleri _0024self_306;

		public oyunBaslat_002437(ekranGoruntuleri self_)
		{
			_0024self_306 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_306);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class aracSecimKapat_002439 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal soruEkrani _0024soruGetir_0024295;

			internal int _0024deger296;

			internal ekranGoruntuleri _0024self_297;

			public _0024(int deger, ekranGoruntuleri self_)
			{
				_0024deger296 = deger;
				_0024self_297 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024self_297.aracSecimGoster = false;
					_0024self_297.aracSecilenGoster = true;
					tusKilidi = true;
					_0024self_297.param = _0024deger296;
					return base.Yield(2, new WaitForSeconds(1f));
				case 2:
					_0024self_297.param = 0;
					_0024soruGetir_0024295 = (soruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(soruEkrani));
					_0024self_297.soruSec = true;
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal int _0024deger298;

		internal ekranGoruntuleri _0024self_299;

		public aracSecimKapat_002439(int deger, ekranGoruntuleri self_)
		{
			_0024deger298 = deger;
			_0024self_299 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024deger298, _0024self_299);
		}
	}

	public GUIStyle customGuiStyle_logo;

	public GUIStyle oyuncuSirala;

	public GUIStyle aracSecim;

	public GUIStyle aracSecilen;

	public GUIStyle aracSecilen2;

	public GUIStyle aracSecilen3;

	public GUIStyle aracSecilen4;

	public GUIStyle tersYonStil;

	public bool tersYonUyari;

	public GUIStyle sureStil;

	public GUIStyle kumSaatiStil;

	public GUIStyle geriSayStil1;

	public GUIStyle geriSayStil2;

	public GUIStyle geriSayStil3;

	public GUIStyle sureBittiGoster;

	public bool sureBitti;

	public bool sureGonderildi;

	public bool logoAc;

	public bool siralamaGoster;

	public bool aracSecimGoster;

	public bool aracSecilenGoster;

	public bool soruSec;

	public string secilenOyuncu;

	public int geriSar;

	public int param;

	public int arabaNum;

	public oyuncuSec oyuncu;

	public UnityScript.Lang.Array geriSayim;

	public UnityScript.Lang.Array oyuncular;

	public static bool tusKilidi = false;

	public static bool videoShow = false;

	public bool escBasti;

	public bool logogoster;

	public bool suregoster;

	public string elapsedString;

	public int elapsedInt;

	public float elapsedFloat;

	public string dakika;

	public string saniye;

	public string salise;

	public int virgul;

	public string sure;

	public float baslangicSure;

	public float soruBaslangic;

	public bool soruKontrol;

	public string sonSure;

	public PuanToplama puanlar;

	public string dakikaSon;

	public string saniyeSon;

	public string saliseSon;

	public int sureSonInt;

	public float sureSonFloat;

	public int virgulSon;

	public string oyunSonuSure2;

	public string oyunSonuSure2Hediyeli;

	public bool menuSecim;

	public GUIStyle icMenu;

	public GUIStyle menu1;

	public GUIStyle menu2;

	public GUIStyle menu3;

	public GUIStyle[] goruntuK;

	public GUIStyle[] sesK;

	public GUIStyle onayla;

	public GUIStyle iptal;

	public static int degerG = 2;

	public static int degerS = 5;

	public static float sesDuzeyi = 1f;

	public GUIStyle arti;

	public GUIStyle eksi;

	public ekranGoruntuleri()
	{
		tersYonUyari = true;
		sureBitti = false;
		sureGonderildi = false;
		logoAc = false;
		siralamaGoster = false;
		aracSecimGoster = false;
		aracSecilenGoster = false;
		soruSec = false;
		geriSar = 0;
		param = 0;
		arabaNum = 0;
		geriSayim = new UnityScript.Lang.Array(new object[4] { "3", "2", "1", "Basla" });
		oyuncular = new UnityScript.Lang.Array(new object[4] { "Birinci Oyuncu Ismi", "Ikinci Oyuncu Ismi", "Ucuncu Oyuncu Ismi", "Dorduncu Oyuncu Ismi" });
		escBasti = false;
		logogoster = true;
		suregoster = false;
		sure = "00:00:00";
		soruKontrol = false;
		menuSecim = false;
	}

	public IEnumerator basaDon()
	{
		return new basaDon_002433().GetEnumerator();
	}

	public void siralamaKapat(int deger)
	{
		aracSecimGoster = true;
		siralamaGoster = false;
		secilenOyuncu = (string)RuntimeServices.Coerce(oyuncular[checked(deger - 1)], typeof(string));
	}

	public IEnumerator aracSecimKapat(int deger)
	{
		return new aracSecimKapat_002439(deger, this).GetEnumerator();
	}

	public void videoKapat()
	{
		GameObject val = GameObject.Find("logoGirisOynat");
		UnityEngine.Object.Destroy((UnityEngine.Object)(object)val);
		siralamaGoster = true;
		logoAc = false;
		videoShow = false;
	}

	public IEnumerator geriSaydir()
	{
		return new geriSaydir_002435(this).GetEnumerator();
	}

	public IEnumerator oyunBaslat()
	{
		return new oyunBaslat_002437(this).GetEnumerator();
	}

	public void sonSureAyarla(int cezaSaniye)
	{
		checked
		{
			int num = (int)(Time.timeSinceLevelLoad - baslangicSure);
			float num2 = Time.timeSinceLevelLoad - baslangicSure;
			int intSure = num - PuanToplama.hediyeSayisi + cezaSaniye;
			float floatSure = num2 - (float)PuanToplama.hediyeSayisi + (float)cezaSaniye;
			oyunSonuSure2 = sureStringAl(num, num2);
			oyunSonuSure2Hediyeli = sureStringAl(intSure, floatSure);
		}
	}

	public string sureStringAl(int intSure, float floatSure)
	{
		string result = default(string);
		try
		{
			string text = UnityBuiltins.parseInt(floatSure / 60f).ToString();
			string text2 = UnityBuiltins.parseInt(floatSure % 60f).ToString();
			string text3 = (UnityBuiltins.parseInt(floatSure * 100f) % 100).ToString();
			if (((text).Length) == 1)
			{
				text = "0" + text;
			}
			if (((text2).Length) == 1)
			{
				text2 = "0" + text2;
			}
			if (((text3).Length) == 1)
			{
				text3 = "0" + text3;
			}
			result = text + ":" + text2 + ":" + text3;
			return result;
		}
		catch (Exception)
		{
		}
		return result;
	}

	public void Start()
	{
		oyuncu = (oyuncuSec)(object)UnityEngine.Object.FindObjectOfType(typeof(oyuncuSec));
		puanlar = (PuanToplama)(object)UnityEngine.Object.FindObjectOfType(typeof(PuanToplama));
	}

	public void soruSureBaslat()
	{
		soruBaslangic = Time.timeSinceLevelLoad;
		soruKontrol = true;
	}

	public void sureBaslat()
	{
		baslangicSure = Time.timeSinceLevelLoad;
	}

	public void escapeTusu(bool param)
	{
		switch (param)
		{
		case false:
			Time.timeScale = 0f;
			menuSecim = true;
			escBasti = true;
			break;
		case true:
			Time.timeScale = 1f;
			menuSecim = false;
			escBasti = false;
			break;
		}
	}

	public void Update()
	{
		if (Input.GetKeyUp((KeyCode)27))
		{
			if (!escBasti)
			{
				escapeTusu(param: false);
			}
			else if (escBasti)
			{
				escapeTusu(param: true);
			}
		}
		if (soruKontrol && !(Time.timeSinceLevelLoad - soruBaslangic < 10f))
		{
			soruKontrol = false;
		}
		if (!(Time.timeSinceLevelLoad - baslangicSure < 180f))
		{
			sureBitti = true;
			Time.timeScale = 0.001f;
		}
	}

	public string oyunSonuSure()
	{
		try
		{
			sureSonInt = checked((int)(Time.timeSinceLevelLoad - baslangicSure - (float)PuanToplama.hediyeSayisi));
			sureSonFloat = Time.timeSinceLevelLoad - baslangicSure - (float)PuanToplama.hediyeSayisi;
			dakikaSon = (sureSonInt / 60).ToString();
			virgulSon = sureSonInt.ToString().IndexOf(",");
			saniyeSon = (sureSonInt % 60).ToString();
			saliseSon = sureSonFloat.ToString().Substring(checked(virgul + 1), 2);
			if (virgul != -1)
			{
				if (((saniyeSon).Length) == 1)
				{
					saniyeSon = "0" + saniyeSon;
				}
				if (((dakikaSon).Length) == 1)
				{
					dakikaSon = "0" + dakikaSon;
				}
			}
			if (elapsedFloat < 0f)
			{
				sonSure = "00:00:00";
			}
			else
			{
				sonSure = dakikaSon + ":" + saniyeSon + ":" + saliseSon;
			}
		}
		catch (Exception)
		{
			MonoBehaviour.print((object)elapsedString);
		}
		return sonSure;
	}

	public string sureyiAl()
	{
		if (suregoster)
		{
			try
			{
				elapsedFloat = Time.timeSinceLevelLoad - baslangicSure;
				elapsedInt = checked((int)(Time.timeSinceLevelLoad - baslangicSure));
				elapsedString = (Time.timeSinceLevelLoad - baslangicSure).ToString();
				dakika = (elapsedInt / 60).ToString();
				virgul = elapsedString.IndexOf(",");
				if (virgul != -1)
				{
					saniye = (elapsedInt % 60).ToString();
					salise = elapsedString.Substring(checked(virgul + 1), 2);
					if (((saniye).Length) == 1)
					{
						saniye = "0" + saniye;
					}
					if (((dakika).Length) == 1)
					{
						dakika = "0" + dakika;
					}
				}
			}
			catch (Exception)
			{
				MonoBehaviour.print((object)elapsedString);
			}
			if (elapsedFloat < 0f)
			{
				sure = "00:00:00";
			}
			else
			{
				sure = dakika + ":" + saniye + ":" + salise;
			}
		}
		return sure;
	}

	public void OnGUI()
	{
		checked
		{
			if (menuSecim)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 740), (float)(unchecked(Screen.height / 2) - 400), 1280f, 800f), string.Empty, icMenu);
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 219), (float)(unchecked(Screen.height / 2) - 135), 438f, 65f), string.Empty, menu1))
				{
					Application.LoadLevel("oyunMenu");
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 221), (float)(unchecked(Screen.height / 2) - 5), 48f, 49f), string.Empty, arti) && degerG < 2)
				{
					degerG++;
					if (degerG == 0)
					{
						QualitySettings.currentLevel = (QualityLevel)0;
					}
					else if (degerG == 1)
					{
						QualitySettings.currentLevel = (QualityLevel)3;
					}
					else if (degerG == 2)
					{
						QualitySettings.currentLevel = (QualityLevel)5;
					}
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) - 5), 48f, 49f), string.Empty, eksi) && degerG > 0)
				{
					degerG--;
					if (degerG == 0)
					{
						QualitySettings.currentLevel = (QualityLevel)0;
					}
					else if (degerG == 1)
					{
						QualitySettings.currentLevel = (QualityLevel)3;
					}
					else if (degerG == 2)
					{
						QualitySettings.currentLevel = (QualityLevel)5;
					}
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 221), (float)(unchecked(Screen.height / 2) + 100), 48f, 49f), string.Empty, arti) && degerS < 5)
				{
					degerS++;
					sesDuzeyi += 0.2f;
					AudioListener.volume = sesDuzeyi;
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) + 100), 48f, 49f), string.Empty, eksi) && degerS > 0)
				{
					degerS--;
					sesDuzeyi -= 0.2f;
					AudioListener.volume = sesDuzeyi;
				}
				Rect val = new Rect((float)(unchecked(Screen.width / 2) - 221), (float)(unchecked(Screen.height / 2) - 46), 422f, 93f);
				string empty = string.Empty;
				GUIStyle[] array = goruntuK;
				GUI.Label(val, empty, array[RuntimeServices.NormalizeArrayIndex((System.Array)array, degerG)]);
				Rect val2 = new Rect((float)(unchecked(Screen.width / 2) - 221), (float)(unchecked(Screen.height / 2) + 59), 422f, 93f);
				string empty2 = string.Empty;
				GUIStyle[] array2 = sesK;
				GUI.Label(val2, empty2, array2[RuntimeServices.NormalizeArrayIndex((System.Array)array2, degerS)]);
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 116), (float)(unchecked(Screen.height / 2) + 180), 116f, 43f), string.Empty, onayla))
				{
					escapeTusu(param: true);
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 10), (float)(unchecked(Screen.height / 2) + 180), 116f, 43f), string.Empty, iptal))
				{
					degerG = 0;
					degerS = 3;
					escapeTusu(param: true);
				}
			}
			if (sureBitti)
			{
				if (!sureGonderildi)
				{
					((MonoBehaviour)this).StartCoroutine_Auto(basaDon());
					sureGonderildi = true;
				}
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 158), (float)(unchecked(Screen.height / 2) - 237), 316f, 474f), string.Empty, sureBittiGoster);
			}
			if (tersYonUyari)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 512), (float)(unchecked(Screen.height / 2) - 384), 1024f, 768f), string.Empty, tersYonStil);
			}
			if (!videoShow)
			{
				GUI.Label(new Rect((float)(Screen.width - 195), 30f, 180f, 69f), sureyiAl(), sureStil);
				GUI.Label(new Rect((float)(Screen.width - 140), 100f, 103f, 150f), PuanToplama.hediyeSayisi.ToString(), kumSaatiStil);
			}
			if (siralamaGoster)
			{
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeof(GUI), "Button", new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 350), 100f, 771f, 81f),
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"1     ", oyuncular[0]),
					oyuncuSirala
				})))
				{
				}
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeof(GUI), "Button", new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 350), 185f, 771f, 81f),
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"2     ", oyuncular[1]),
					oyuncuSirala
				})))
				{
				}
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeof(GUI), "Button", new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 350), 270f, 771f, 81f),
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"3     ", oyuncular[2]),
					oyuncuSirala
				})))
				{
				}
				if (!RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeof(GUI), "Button", new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 350), 355f, 771f, 81f),
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"4     ", oyuncular[3]),
					oyuncuSirala
				})))
				{
				}
			}
			else if (logoAc)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 261), (float)(unchecked(Screen.height / 2) - 192), 512f, 384f), string.Empty, customGuiStyle_logo);
			}
			if (aracSecimGoster)
			{
				GUI.Label(new Rect(0f, (float)(unchecked(Screen.height / 2) - 384), (float)Screen.width, 768f), string.Empty, aracSecim);
			}
			switch (geriSar)
			{
			case 1:
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 28), (float)(unchecked(Screen.height / 2) - 180), 57f, 118f), string.Empty, geriSayStil3);
				break;
			case 2:
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 28), (float)(unchecked(Screen.height / 2) - 180), 57f, 118f), string.Empty, geriSayStil2);
				break;
			case 3:
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 28), (float)(unchecked(Screen.height / 2) - 180), 57f, 118f), string.Empty, geriSayStil1);
				break;
			}
		}
	}

	public void Main()
	{
		videoKapat();
	}
}
