using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class soruEkrani : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class soruKontrol_002434 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal bool _0024cevap315;

			internal string _0024secim316;

			internal soruEkrani _0024self_317;

			public _0024(bool cevap, string secim, soruEkrani self_)
			{
				_0024cevap315 = cevap;
				_0024secim316 = secim;
				_0024self_317 = self_;
			}

			public override bool MoveNext()
			{
				checked
				{
					switch (base._state)
					{
					default:
						if (_0024cevap315)
						{
							_0024self_317.dogruCevapSes.Play();
							_0024self_317.dogruCevapSay++;
							if (_0024secim316 == "a")
							{
								_0024self_317.soruASecim = 1;
								return base.Yield(2, new WaitForSeconds(2f));
							}
							_0024self_317.soruBSecim = 1;
							return base.Yield(3, new WaitForSeconds(2f));
						}
						_0024self_317.yanlisCevapSes.Play();
						_0024self_317.yanlisCevapSay++;
						if (_0024secim316 == "a")
						{
							_0024self_317.soruASecim = 1;
							return base.Yield(4, new WaitForSeconds(2f));
						}
						_0024self_317.soruBSecim = 1;
						return base.Yield(5, new WaitForSeconds(2f));
					case 2:
						_0024self_317.soruASecim = 2;
						goto IL_016e;
					case 3:
						_0024self_317.soruBSecim = 2;
						goto IL_016e;
					case 4:
						_0024self_317.soruASecim = 3;
						goto IL_016e;
					case 5:
						_0024self_317.soruBSecim = 3;
						goto IL_016e;
					case 6:
						_0024self_317.soruASecim = 0;
						_0024self_317.soruBSecim = 0;
						_0024self_317.yeniKilit.soruTusKilit = false;
						_0024self_317.soruSor();
						base.Yield(1, (WaitForSeconds)null);
						break;
					case 1:
						break;
						IL_016e:
						return base.Yield(6, new WaitForSeconds(1.5f));
					}
					bool result = default(bool);
					return result;
				}
			}
		}

		internal bool _0024cevap318;

		internal string _0024secim319;

		internal soruEkrani _0024self_320;

		public soruKontrol_002434(bool cevap, string secim, soruEkrani self_)
		{
			_0024cevap318 = cevap;
			_0024secim319 = secim;
			_0024self_320 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024cevap318, _0024secim319, _0024self_320);
		}
	}

	public GUIStyle soruUST;

	public GUIStyle soruYaz;

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

	public GUIStyle dogruCevapStil;

	public GUIStyle yanlisCevapStil;

	public GUIStyle soru1;

	public GUIStyle soru2;

	public GUIStyle soru3;

	public GUIStyle soru4;

	public GUIStyle soru5;

	public GUIStyle soru6;

	public GUIStyle soru7;

	public GUIStyle soru8;

	public GUIStyle soru9;

	public GUIStyle soru10;

	public GUIStyle soru11;

	public GUIStyle soru12;

	public GUIStyle soru13;

	public GUIStyle soru14;

	public GUIStyle soru15;

	public GUIStyle soru16;

	public GUIStyle soru17;

	public GUIStyle soru18;

	public GUIStyle soru19;

	public GUIStyle soru20;

	public GUIStyle soru21;

	public GUIStyle soru22;

	public GUIStyle soru23;

	public GUIStyle soru24;

	public GUIStyle soru25;

	public GUIStyle soru26;

	public GUIStyle soru27;

	public GUIStyle soru28;

	public GUIStyle soru29;

	public GUIStyle soru30;

	public GUIStyle soru31;

	public GUIStyle soru32;

	public GUIStyle soru33;

	public GUIStyle soru34;

	public GUIStyle soru35;

	public GUIStyle soru36;

	public GUIStyle soru37;

	public GUIStyle soru38;

	public GUIStyle soru39;

	public GUIStyle soru40;

	public GUIStyle soru41;

	public GUIStyle soru42;

	public GUIStyle soru43;

	public GUIStyle soru44;

	public GUIStyle soru45;

	public GUIStyle soru46;

	public GUIStyle soru47;

	public GUIStyle soru48;

	public GUIStyle soru49;

	public GUIStyle soru50;

	public GUIStyle soru51;

	public GUIStyle soru52;

	public GUIStyle soru53;

	public GUIStyle soru54;

	public GUIStyle soru55;

	public GUIStyle soru56;

	public GUIStyle soru57;

	public GUIStyle soru58;

	public GUIStyle soru59;

	public GUIStyle soru60;

	public GUIStyle soru61;

	public GUIStyle soru62;

	public GUIStyle soru63;

	public GUIStyle soru64;

	public GUIStyle soru65;

	public GUIStyle soru66;

	public GUIStyle soru67;

	public GUIStyle soru68;

	public GUIStyle soru69;

	public GUIStyle soru70;

	public GUIStyle soru71;

	public GUIStyle soru72;

	public GUIStyle soru73;

	public GUIStyle soru74;

	public GUIStyle soru75;

	public GUIStyle soru76;

	public GUIStyle soru77;

	public GUIStyle soru78;

	public GUIStyle soru79;

	public GUIStyle soru80;

	public GUIStyle soru81;

	public GUIStyle soru82;

	public GUIStyle soru83;

	public GUIStyle soru84;

	public GUIStyle soru85;

	public GUIStyle soru86;

	public GUIStyle soru87;

	public GUIStyle soru88;

	public GUIStyle soru89;

	public GUIStyle soru90;

	public GUIStyle soru91;

	public GUIStyle soru92;

	public GUIStyle soru93;

	public GUIStyle soru94;

	public GUIStyle soru95;

	public GUIStyle soru96;

	public GUIStyle soru97;

	public GUIStyle soru98;

	public GUIStyle soru99;

	public GUIStyle soru100;

	public GUIStyle soru101;

	public GUIStyle[] guis;

	public bool soruAc;

	public bool soruAcSon;

	public int soruKac;

	public int cevapKac;

	public int dogruCevapSay;

	public int yanlisCevapSay;

	public bool soruBasi;

	public bool sorularAlindi;

	public int soruSayisiKac;

	public int sec;

	public UnityScript.Lang.Array SorularJ;

	public UnityScript.Lang.Array CevaplarJ;

	public int diziNumber;

	public AudioSource dogruCevapSes;

	public AudioSource yanlisCevapSes;

	public kilit yeniKilit;

	public bool araciEkle;

	public soruEkrani()
	{
		soruASecim = 0;
		soruBSecim = 0;
		soruAc = false;
		soruAcSon = false;
		soruKac = 0;
		cevapKac = 0;
		dogruCevapSay = 0;
		yanlisCevapSay = 0;
		soruBasi = true;
		sorularAlindi = false;
		SorularJ = new UnityScript.Lang.Array();
		CevaplarJ = new UnityScript.Lang.Array();
		araciEkle = false;
	}

	public void soruGetir()
	{
		soruAc = true;
	}

	public void sorulariAl(string[] sorular)
	{
		for (int i = 0; i < ((sorular).Length); i = checked(i + 1))
		{
			SorularJ[i] = sorular[RuntimeServices.NormalizeArrayIndex((System.Array)sorular, i)];
		}
	}

	public void cevaplariAl(string[] cevaplar)
	{
		for (int i = 0; i < ((cevaplar).Length); i = checked(i + 1))
		{
			CevaplarJ[i] = cevaplar[RuntimeServices.NormalizeArrayIndex((System.Array)cevaplar, i)];
		}
	}

	public IEnumerator soruKontrol(bool cevap, string secim)
	{
		return new soruKontrol_002434(cevap, secim, this).GetEnumerator();
	}

	public void soruSor()
	{
		checked
		{
			soruKac++;
			cevapKac++;
			sec = UnityEngine.Random.Range(1, 10);
		}
	}

	public void soruKontrol()
	{
		SoruTopla soruTopla = (SoruTopla)(object)UnityEngine.Object.FindObjectOfType(typeof(SoruTopla));
		yarisSonuc yarisSonuc2 = (yarisSonuc)(object)UnityEngine.Object.FindObjectOfType(typeof(yarisSonuc));
		if (SoruTopla.soruSayisi > 0)
		{
			((Component)this).gameObject.SendMessage("sorulariSec", (object)SoruTopla.soruSayisi);
			yarisSonuc2.sonucGoster = false;
			sorularAlindi = true;
			soruAc = true;
		}
	}

	public void Start()
	{
		soruAc = false;
		soruAcSon = false;
		soruKac = 0;
		cevapKac = 0;
		dogruCevapSay = 0;
		yanlisCevapSay = 0;
		soruBasi = true;
		sorularAlindi = false;
		yeniKilit = (kilit)(object)UnityEngine.Object.FindObjectOfType(typeof(kilit));
	}

	public void OnGUI()
	{
		if (!soruAc)
		{
			return;
		}
		checked
		{
			Rect val = new Rect((float)(unchecked(Screen.width / 2) - 210), (float)(unchecked(Screen.height / 2) - 240), 465f, 176f);
			string empty = string.Empty;
			GUIStyle[] array = guis;
			GUI.Label(val, empty, array[RuntimeServices.NormalizeArrayIndex((System.Array)array, RuntimeServices.UnboxInt32(RuntimeServices.InvokeBinaryOperator("op_Subtraction", RuntimeServices.Invoke((object)typeof(UnityBuiltins), "parseInt", new object[1] { SorularJ[soruKac] }), (object)1)))]);
			if (sec < 5)
			{
				Type typeFromHandle = typeof(GUI);
				object[] obj = new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) - 65), 542f, 145f),
					CevaplarJ[cevapKac * 2],
					null
				};
				GUIStyle[] array2 = soruDiz;
				obj[2] = array2[RuntimeServices.NormalizeArrayIndex((System.Array)array2, soruASecim)];
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle, "Button", obj)))
				{
					if (soruBasi && !yeniKilit.soruTusKilit)
					{
						yeniKilit.soruTusKilit = true;
						if (soruKac + 1 < SorularJ.length - 1)
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
							}
						}
						else
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
							}
							araciEkle = true;
							((MonoBehaviour)yeniKilit).StartCoroutine_Auto(yeniKilit.baslat());
						}
					}
				}
				else
				{
					Type typeFromHandle2 = typeof(GUI);
					object[] obj2 = new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) + 80), 542f, 145f),
						CevaplarJ[cevapKac * 2 + 1],
						null
					};
					GUIStyle[] array3 = soruDizB;
					obj2[2] = array3[RuntimeServices.NormalizeArrayIndex((System.Array)array3, soruBSecim)];
					if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle2, "Button", obj2)) && soruBasi && !yeniKilit.soruTusKilit)
					{
						yeniKilit.soruTusKilit = true;
						if (soruKac + 1 < SorularJ.length - 1)
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
							}
						}
						else
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
							}
							araciEkle = true;
							((MonoBehaviour)yeniKilit).StartCoroutine_Auto(yeniKilit.baslat());
						}
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
				GUIStyle[] array4 = soruDiz;
				obj3[2] = array4[RuntimeServices.NormalizeArrayIndex((System.Array)array4, soruASecim)];
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle3, "Button", obj3)))
				{
					if (soruBasi && !yeniKilit.soruTusKilit)
					{
						yeniKilit.soruTusKilit = true;
						if (soruKac + 1 < SorularJ.length - 1)
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
							}
						}
						else
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "a"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "a"));
							}
							araciEkle = true;
							((MonoBehaviour)yeniKilit).StartCoroutine_Auto(yeniKilit.baslat());
						}
					}
				}
				else
				{
					Type typeFromHandle4 = typeof(GUI);
					object[] obj4 = new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) + 80), 542f, 145f),
						CevaplarJ[cevapKac * 2],
						null
					};
					GUIStyle[] array5 = soruDizB;
					obj4[2] = array5[RuntimeServices.NormalizeArrayIndex((System.Array)array5, soruBSecim)];
					if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeFromHandle4, "Button", obj4)) && soruBasi && !yeniKilit.soruTusKilit)
					{
						yeniKilit.soruTusKilit = true;
						if (soruKac + 1 < SorularJ.length - 1)
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
							}
						}
						else
						{
							if (sec < 5)
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: false, "b"));
							}
							else
							{
								((MonoBehaviour)this).StartCoroutine_Auto(soruKontrol(cevap: true, "b"));
							}
							araciEkle = true;
							((MonoBehaviour)yeniKilit).StartCoroutine_Auto(yeniKilit.baslat());
						}
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
		guis[0] = soru1;
		guis[1] = soru2;
		guis[2] = soru3;
		guis[3] = soru4;
		guis[4] = soru5;
		guis[5] = soru6;
		guis[6] = soru7;
		guis[7] = soru8;
		guis[8] = soru9;
		guis[9] = soru10;
		guis[10] = soru11;
		guis[11] = soru12;
		guis[12] = soru13;
		guis[13] = soru14;
		guis[14] = soru15;
		guis[15] = soru16;
		guis[16] = soru17;
		guis[17] = soru18;
		guis[18] = soru19;
		guis[19] = soru20;
		guis[20] = soru21;
		guis[21] = soru22;
		guis[22] = soru23;
		guis[23] = soru24;
		guis[24] = soru25;
		guis[25] = soru26;
		guis[26] = soru27;
		guis[27] = soru28;
		guis[28] = soru29;
		guis[29] = soru30;
		guis[30] = soru31;
		guis[31] = soru32;
		guis[32] = soru33;
		guis[33] = soru34;
		guis[34] = soru35;
		guis[35] = soru36;
		guis[36] = soru37;
		guis[37] = soru38;
		guis[38] = soru39;
		guis[39] = soru40;
		guis[40] = soru41;
		guis[41] = soru42;
		guis[42] = soru43;
		guis[43] = soru44;
		guis[44] = soru45;
		guis[45] = soru46;
		guis[46] = soru47;
		guis[47] = soru48;
		guis[48] = soru49;
		guis[49] = soru50;
		guis[50] = soru51;
		guis[51] = soru52;
		guis[52] = soru53;
		guis[53] = soru54;
		guis[54] = soru55;
		guis[55] = soru56;
		guis[56] = soru57;
		guis[57] = soru58;
		guis[58] = soru59;
		guis[59] = soru60;
		guis[60] = soru61;
		guis[61] = soru62;
		guis[62] = soru63;
		guis[63] = soru64;
		guis[64] = soru65;
		guis[65] = soru66;
		guis[66] = soru67;
		guis[67] = soru68;
		guis[68] = soru69;
		guis[69] = soru70;
		guis[70] = soru71;
		guis[71] = soru72;
		guis[72] = soru73;
		guis[73] = soru74;
		guis[74] = soru75;
		guis[75] = soru76;
		guis[76] = soru77;
		guis[77] = soru78;
		guis[78] = soru79;
		guis[79] = soru80;
		guis[80] = soru81;
		guis[81] = soru82;
		guis[82] = soru83;
		guis[83] = soru84;
		guis[84] = soru85;
		guis[85] = soru86;
		guis[86] = soru87;
		guis[87] = soru88;
		guis[88] = soru89;
		guis[89] = soru90;
		guis[90] = soru91;
		guis[91] = soru92;
		guis[92] = soru93;
		guis[93] = soru94;
		guis[94] = soru95;
		guis[95] = soru96;
		guis[96] = soru97;
		guis[97] = soru98;
		guis[98] = soru99;
		guis[99] = soru100;
	}
}
