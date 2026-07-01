using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class oyunSonuSoruEkrani : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class soruKontrol_002440 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024cevap309;

			internal string _0024secim310;

			internal oyunSonuSoruEkrani _0024self_311;

			public _0024(bool cevap, string secim, oyunSonuSoruEkrani self_)
			{
				_0024cevap309 = cevap;
				_0024secim310 = secim;
				_0024self_311 = self_;
			}

			public override bool MoveNext()
			{
				checked
				{
					switch (base._state)
					{
					default:
						MonoBehaviour.print((object)_0024secim310);
						if (_0024cevap309)
						{
							_0024self_311.dogruCevapSay++;
							PuanToplama.hediyeSayisi += 2;
							if (_0024secim310 == "a")
							{
								_0024self_311.soruASecim = 1;
								MonoBehaviour.print((object)"a secti");
								return base.Yield(2, new WaitForSeconds(0.0002f));
							}
							_0024self_311.soruBSecim = 1;
							return base.Yield(3, new WaitForSeconds(0.0002f));
						}
						_0024self_311.yanlisCevapSay++;
						_0024self_311.yarisSonu.soruSaniye = _0024self_311.yarisSonu.soruSaniye + 2;
						if (_0024secim310 == "a")
						{
							_0024self_311.soruASecim = 1;
							MonoBehaviour.print((object)"a secti");
							return base.Yield(4, new WaitForSeconds(0.0002f));
						}
						_0024self_311.soruBSecim = 1;
						return base.Yield(5, new WaitForSeconds(0.0002f));
					case 2:
						MonoBehaviour.print((object)"burayadaGecti");
						_0024self_311.soruASecim = 2;
						goto IL_01bb;
					case 3:
						_0024self_311.soruBSecim = 2;
						goto IL_01bb;
					case 4:
						MonoBehaviour.print((object)"burayadaGecti");
						_0024self_311.soruASecim = 3;
						goto IL_01bb;
					case 5:
						_0024self_311.soruBSecim = 3;
						goto IL_01bb;
					case 6:
						_0024self_311.soruASecim = 0;
						_0024self_311.soruBSecim = 0;
						_0024self_311.yeniKilit.soruTusKilit = false;
						_0024self_311.soruSor();
						base.Yield(1, (WaitForSeconds)null);
						break;
					case 1:
						break;
						IL_01bb:
						return base.Yield(6, new WaitForSeconds(0.0001f));
					}
					bool result = default(bool);
					return result;
				}
			}
		}

		internal bool _0024cevap312;

		internal string _0024secim313;

		internal oyunSonuSoruEkrani _0024self_314;

		public soruKontrol_002440(bool cevap, string secim, oyunSonuSoruEkrani self_)
		{
			_0024cevap312 = cevap;
			_0024secim313 = secim;
			_0024self_314 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024cevap312, _0024secim313, _0024self_314);
		}
	}

	public GUIStyle soruUST;

	public GUIStyle soruYaz;

	public GUIStyle dogruCevapStil;

	public GUIStyle yanlisCevapStil;

	public bool soruAc;

	public bool soruAcSon;

	public int soruKac;

	public int cevapKac;

	public int dogruCevapSay;

	public int yanlisCevapSay;

	public bool soruBasi;

	public bool sorularAlindi;

	public int soruSayisiKac;

	public bool oyunSonuSoru;

	public static int sec;

	public UnityScript.Lang.Array SorularJ;

	public UnityScript.Lang.Array CevaplarJ;

	public bool tusKilidi;

	public PuanToplama puanlar;

	public yarisSonuc yarisSonu;

	public ekranGoruntuleri oyunSonSure;

	public GUIStyle soruA;

	public GUIStyle soruA_Sec;

	public GUIStyle soruA_Dogru;

	public GUIStyle soruA_Yanlis;

	public GUIStyle soruB;

	public GUIStyle soruB_Sec;

	public GUIStyle soruB_Dogru;

	public GUIStyle soruB_Yanlis;

	public int soruASecim;

	public int soruBSecim;

	public GUIStyle[] soruDiz;

	public GUIStyle[] soruDizB;

	public SoruTopla soruToplar;

	public kilit yeniKilit;

	public oyunSonuSoruEkrani()
	{
		soruAc = false;
		soruAcSon = false;
		soruKac = 0;
		cevapKac = 0;
		dogruCevapSay = 0;
		yanlisCevapSay = 0;
		soruBasi = true;
		sorularAlindi = false;
		oyunSonuSoru = false;
		SorularJ = new UnityScript.Lang.Array();
		CevaplarJ = new UnityScript.Lang.Array();
		tusKilidi = true;
		soruASecim = 0;
		soruBSecim = 0;
	}

	public void soruGetir()
	{
		soruAc = true;
	}

	public void sorulariAlSonu(string[] sorular)
	{
		MonoBehaviour.print((object)"burayada geldii");
		for (int i = 0; i < ((sorular).Length); i = checked(i + 1))
		{
			SorularJ[i] = sorular[RuntimeServices.NormalizeArrayIndex((System.Array)sorular, i)];
			MonoBehaviour.print(SorularJ[i]);
		}
	}

	public void cevaplariAlSonu(string[] cevaplar)
	{
		for (int i = 0; i < ((cevaplar).Length); i = checked(i + 1))
		{
			CevaplarJ[i] = cevaplar[RuntimeServices.NormalizeArrayIndex((System.Array)cevaplar, i)];
		}
	}

	public IEnumerator soruKontrol(bool cevap, string secim)
	{
		return new soruKontrol_002440(cevap, secim, this).GetEnumerator();
	}

	public void soruSor()
	{
		checked
		{
			if (soruKac + 1 < SorularJ.length)
			{
				soruKac++;
				cevapKac++;
				sec = UnityEngine.Random.Range(1, 10);
			}
			else
			{
				tusKilidi = true;
				soruAc = false;
				oyunSonuSoru = false;
			oyunSonSure.sonSureAyarla(0);
			}
		}
	}

	public void soruKontrolSonu()
	{
		yarisSonuc yarisSonuc2 = (yarisSonuc)(object)UnityEngine.Object.FindObjectOfType(typeof(yarisSonuc));
		if (SoruTopla.soruSayisi > 0)
		{
			oyunSonuSoru = true;
			((Component)this).gameObject.SendMessage("sorulariSec", (object)SoruTopla.soruSayisi);
			tusKilidi = false;
		}
		else
		{
			oyunSonuSoru = false;
		}
	}

	public void Start()
	{
		soruToplar = (SoruTopla)(object)UnityEngine.Object.FindObjectOfType(typeof(SoruTopla));
		puanlar = (PuanToplama)(object)UnityEngine.Object.FindObjectOfType(typeof(PuanToplama));
		soruAc = false;
		soruAcSon = false;
		soruKac = 0;
		cevapKac = 0;
		dogruCevapSay = 0;
		yanlisCevapSay = 0;
		soruBasi = true;
		sorularAlindi = false;
		SoruTopla.soruSayisi = 0;
		yeniKilit = (kilit)(object)UnityEngine.Object.FindObjectOfType(typeof(kilit));
		yarisSonu = (yarisSonuc)(object)UnityEngine.Object.FindObjectOfType(typeof(yarisSonuc));
		oyunSonSure = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
	}

	public void Update()
	{
		if (tusKilidi || yeniKilit.soruTusKilit)
		{
			return;
		}
		if (Input.GetButtonUp("Fire2") || Input.GetKeyUp("a"))
		{
			yeniKilit.soruTusKilit = true;
			if (sec < 5)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
			}
		}
		else if (Input.GetButtonUp("Fire1") || Input.GetKeyUp("b"))
		{
			yeniKilit.soruTusKilit = true;
			if (sec < 5)
			{
				((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
			}
		}
	}

	public void OnGUI()
	{
		if (!soruAc)
		{
			return;
		}
		checked
		{
			UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
			{
				(object)new Rect((float)(unchecked(Screen.width / 2) - 210), (float)(unchecked(Screen.height / 2) - 240), 465f, 176f),
				SorularJ[soruKac],
				soruYaz
			}, typeof(MonoBehaviour));
			if (sec < 5)
			{
				Type typeFromHandle = typeof(GUI);
				object[] obj = new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) - 65), 542f, 145f),
					CevaplarJ[cevapKac * 2],
					null
				};
				GUIStyle[] array = soruDiz;
				obj[2] = array[RuntimeServices.NormalizeArrayIndex((System.Array)array, soruASecim)];
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle, "Button", obj)) && !yeniKilit.soruTusKilit)
				{
					yeniKilit.soruTusKilit = true;
					if (sec < 5)
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
					}
					else
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
					}
				}
				Type typeFromHandle2 = typeof(GUI);
				object[] obj2 = new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) + 80), 542f, 145f),
					CevaplarJ[cevapKac * 2 + 1],
					null
				};
				GUIStyle[] array2 = soruDizB;
				obj2[2] = array2[RuntimeServices.NormalizeArrayIndex((System.Array)array2, soruBSecim)];
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle2, "Button", obj2)) && !yeniKilit.soruTusKilit)
				{
					yeniKilit.soruTusKilit = true;
					if (sec < 5)
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
					}
					else
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
					}
				}
			}
			else
			{
				Type typeFromHandle3 = typeof(GUI);
				object[] obj3 = new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) - 65), 542f, 145f),
					CevaplarJ[cevapKac * 2 + 1],
					null
				};
				GUIStyle[] array3 = soruDiz;
				obj3[2] = array3[RuntimeServices.NormalizeArrayIndex((System.Array)array3, soruASecim)];
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle3, "Button", obj3)) && !yeniKilit.soruTusKilit)
				{
					yeniKilit.soruTusKilit = true;
					if (sec < 5)
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
					}
					else
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
					}
				}
				Type typeFromHandle4 = typeof(GUI);
				object[] obj4 = new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) + 80), 542f, 145f),
					CevaplarJ[cevapKac * 2],
					null
				};
				GUIStyle[] array4 = soruDizB;
				obj4[2] = array4[RuntimeServices.NormalizeArrayIndex((System.Array)array4, soruBSecim)];
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle4, "Button", obj4)) && !yeniKilit.soruTusKilit)
				{
					yeniKilit.soruTusKilit = true;
					if (sec < 5)
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
					}
					else
					{
						((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
					}
				}
			}
			GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 210), (float)(unchecked(Screen.height / 2) + 220), 188f, 71f), dogruCevapSay.ToString(), dogruCevapStil);
			GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 20), (float)(unchecked(Screen.height / 2) + 220), 188f, 71f), yanlisCevapSay.ToString(), yanlisCevapStil);
		}
	}

	public void Main()
	{
		soruDiz[0] = soruA;
		soruDiz[1] = soruA_Sec;
		soruDiz[2] = soruA_Dogru;
		soruDiz[3] = soruA_Yanlis;
		soruDizB[0] = soruB;
		soruDizB[1] = soruB_Sec;
		soruDizB[2] = soruB_Dogru;
		soruDizB[3] = soruB_Yanlis;
	}
}
