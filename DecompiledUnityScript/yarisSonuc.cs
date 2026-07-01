using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class yarisSonuc : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class skorGonder_002442 : GenericGenerator<WWW>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WWW>, IEnumerator
		{
			internal string _0024yollanacakSkor_0024321;

			internal string _0024url_0024322;

			internal WWW _0024www_0024323;

			internal object _0024skor324;

			internal object _0024kullanici325;

			internal yarisSonuc _0024self_326;

			public _0024(object skor, object kullanici, yarisSonuc self_)
			{
				_0024skor324 = skor;
				_0024kullanici325 = kullanici;
				_0024self_326 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024yollanacakSkor_0024321 = (string)RuntimeServices.Coerce(RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.Invoke(_0024skor324, "Substring", new object[2] { 0, 2 }), (object)"@"), RuntimeServices.Invoke(_0024skor324, "Substring", new object[2] { 3, 2 })), (object)"@"), RuntimeServices.Invoke(_0024skor324, "Substring", new object[2] { 6, 2 })), typeof(string));
					_0024url_0024322 = (string)RuntimeServices.Coerce(RuntimeServices.InvokeBinaryOperator("op_Addition", (object)("http://www.trt.net.tr/trtcocuk/yarisci/skorkaydet.aspx?skor=" + _0024yollanacakSkor_0024321 + "&kullanici="), _0024kullanici325), typeof(string));
					_0024www_0024323 = new WWW(_0024url_0024322);
					return base.Yield(2, _0024www_0024323);
				case 2:
					_0024self_326.cevapSonuc = _0024www_0024323.data;
					base.Yield(1, (WWW)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal object _0024skor327;

		internal object _0024kullanici328;

		internal yarisSonuc _0024self_329;

		public skorGonder_002442(object skor, object kullanici, yarisSonuc self_)
		{
			_0024skor327 = skor;
			_0024kullanici328 = kullanici;
			_0024self_329 = self_;
		}

		public override IEnumerator<WWW> GetEnumerator()
		{
			return (IEnumerator<WWW>)(object)new _0024(_0024skor327, _0024kullanici328, _0024self_329);
		}
	}

	public GUIStyle sonucIsim;

	public GUIStyle sonucSure;

	public GUIStyle derece;

	public GUIStyle odulSure;

	public GUIStyle cezaSure;

	public GUIStyle kalip;

	public GUIStyle siralama;

	public GUIStyle skorSirala;

	public bool sonucGoster;

	public bool siralaGoster;

	public string sureToplami;

	public string sureToplamiSon;

	public int kumsaatiToplam;

	public int yanlisSoruToplam;

	public bool sureAyarlandi;

	public int soruSaniye;

	public int sonOdul;

	public oyuncuSec oyuncu;

	public K_Giris oyuncuK;

	public GUIStyle kaydetM;

	public GUIStyle anamenuM;

	public GUIStyle uyariPanel;

	public static UnityScript.Lang.Array oyuncular = new UnityScript.Lang.Array();

	public static UnityScript.Lang.Array skorlarT = new UnityScript.Lang.Array();

	public PlayerCar_Script oyunDurdur;

	public PuanToplama hediyeSayisiAl;

	public ekranGoruntuleri oyunSonSure;

	public oyunSonuSoruEkrani oyunSonu;

	public int i;

	public bool veriGonder;

	public string cevapSonuc;

	public yarisSonuc()
	{
		sonucGoster = false;
		siralaGoster = false;
		sureAyarlandi = false;
		soruSaniye = 0;
		sonOdul = 0;
		i = 0;
		veriGonder = false;
	}

	public void Start()
	{
		hediyeSayisiAl = (PuanToplama)(object)UnityEngine.Object.FindObjectOfType(typeof(PuanToplama));
		oyunSonSure = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
		oyunSonu = (oyunSonuSoruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(oyunSonuSoruEkrani));
		oyuncu = (oyuncuSec)(object)UnityEngine.Object.FindObjectOfType(typeof(oyuncuSec));
		oyuncuK = (K_Giris)(object)UnityEngine.Object.FindObjectOfType(typeof(K_Giris));
	}

	public void kontrol()
	{
		oyunSonu.soruKontrolSonu();
	}

	public void siralaDoldurOyuncu(string[] isimler)
	{
		for (int i = 0; i < ((isimler).Length); i = checked(i + 1))
		{
			oyuncular[i] = isimler[RuntimeServices.NormalizeArrayIndex((System.Array)isimler, i)];
		}
	}

	public void siralaDoldurZaman(string[] skorlar)
	{
		for (int i = 0; i < ((skorlar).Length); i = checked(i + 1))
		{
			skorlarT[i] = skorlar[RuntimeServices.NormalizeArrayIndex((System.Array)skorlar, i)];
		}
	}

	public IEnumerator skorGonder(object skor, object kullanici)
	{
		cevapSonuc = "true";
		yield return null;
	}

	public void Update()
	{
		if (!oyunSonu.oyunSonuSoru && sonucGoster && !sureAyarlandi)
		{
			oyunSonSure.sonSureAyarla(soruSaniye);
			sureAyarlandi = true;
		}
		if (Input.GetKeyUp("k"))
		{
			AICar_Script aICar_Script = (AICar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(AICar_Script));
			UnityEngine.Object.Destroy((UnityEngine.Object)(object)aICar_Script);
			Application.LoadLevel("OyunMenu");
		}
	}

	public void OnGUI()
	{
		if (oyunSonu.oyunSonuSoru)
		{
			oyunSonu.soruAc = true;
			return;
		}
		checked
		{
			if (sonucGoster)
			{
				sureToplami = oyunSonSure.oyunSonuSure2;
				sureToplamiSon = oyunSonSure.oyunSonuSure2Hediyeli;
				sonOdul = PuanToplama.hediyeSayisi - soruSaniye;
				if (cevapSonuc.Contains("true"))
				{
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 230), (float)(unchecked(Screen.height / 2) - 119), 445f, 238f), "Skor kaydnz tamamlanmtr. Teekkrler.", uyariPanel);
					if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 100), (float)(unchecked(Screen.height / 2) + 130), 181f, 55f), string.Empty, anamenuM))
					{
						Application.LoadLevel("OyunMenu");
					}
				}
				else if (cevapSonuc.Contains("false"))
				{
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 230), (float)(unchecked(Screen.height / 2) - 119), 445f, 238f), "Hata", uyariPanel);
					if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 100), (float)(unchecked(Screen.height / 2) + 130), 181f, 55f), string.Empty, anamenuM))
					{
						Application.LoadLevel("OyunMenu");
					}
				}
				else
				{
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 350), (float)(unchecked(Screen.height / 2) - 250), 680f, 378f), string.Empty, kalip);
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 350), (float)(unchecked(Screen.height / 2) - 215), 770f, 80f), K_Giris.kullaniciAdi, sonucIsim);
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) + 125), (float)(unchecked(Screen.height / 2) - 85), 226f, 133f), soruSaniye.ToString(), sonucSure);
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) + 110), (float)(unchecked(Screen.height / 2) - 5), 226f, 133f), sureToplamiSon, derece);
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) + 125), (float)(unchecked(Screen.height / 2) - 265), 226f, 133f), sureToplami, sonucSure);
					GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 100), (float)(unchecked(Screen.height / 2) - 130), 443f, 78f), sonOdul.ToString(), odulSure);
					if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 100), (float)(unchecked(Screen.height / 2) + 130), 181f, 55f), string.Empty, kaydetM))
					{
						((MonoBehaviour)this).StartCoroutine_Auto(skorGonder(sureToplamiSon, K_Giris.kullaniciAdi));
					}
					if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 85), (float)(unchecked(Screen.height / 2) + 130), 181f, 55f), string.Empty, anamenuM))
					{
						Application.LoadLevel("OyunMenu");
					}
				}
				if (!veriGonder)
				{
					veriGonder = true;
				}
			}
			if (siralaGoster)
			{
				if (oyuncuSec.turModu == 2)
				{
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 230), 771f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"1         ", oyuncular[1]),
						siralama
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 147), 771f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"2         ", oyuncular[0]),
						siralama
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 230), 212f, 80f),
						skorlarT[1],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 147), 212f, 80f),
						skorlarT[0],
						skorSirala
					}, typeof(MonoBehaviour));
				}
				else if (oyuncuSec.turModu == 1)
				{
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 230), 771f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"1         ", oyuncular[3]),
						siralama
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 147), 771f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"2         ", oyuncular[2]),
						siralama
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 65), 771f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"3         ", oyuncular[1]),
						siralama
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) + 17), 771f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"4         ", oyuncular[0]),
						siralama
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 230), 212f, 80f),
						skorlarT[3],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 147), 212f, 80f),
						skorlarT[2],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 65), 212f, 80f),
						skorlarT[1],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) + 17), 212f, 80f),
						skorlarT[0],
						skorSirala
					}, typeof(MonoBehaviour));
				}
			}
		}
	}

	public void Main()
	{
	}
}
