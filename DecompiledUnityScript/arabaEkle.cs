using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class arabaEkle : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class sureTut_002447 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal soruEkrani _0024soruGetir_0024288;

			internal arabaEkle _0024self_289;

			public _0024(arabaEkle self_)
			{
				_0024self_289 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024self_289.sureGeldi = true;
					_0024soruGetir_0024288 = (soruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(soruEkrani));
					_0024soruGetir_0024288.soruGetir();
					return base.Yield(2, new WaitForSeconds(30f));
				case 2:
					if (_0024self_289.ekranTus.soruSec && !_0024self_289.aracEklendi)
					{
						_0024self_289.arabaDegistir(secilenArac);
						_0024self_289.aracEklendi = true;
						((MonoBehaviour)_0024self_289.ekranTus).StartCoroutine_Auto(_0024self_289.ekranTus.oyunBaslat());
					}
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal arabaEkle _0024self_290;

		public sureTut_002447(arabaEkle self_)
		{
			_0024self_290 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_290);
		}
	}

	public Transform arabaSec;

	public Transform arabaSec2;

	public Transform arabaSec3;

	public Transform arabaSec4;

	public Transform yeniaraba;

	public static int secilenArac = 0;

	private bool camTakipEt;

	public soruEkrani soruGetir;

	public oyunSonuSoruEkrani soruGetirSonu;

	public PlayerCar_Script aracHasarAc;

	public GameObject compCar1;

	public GameObject compCar2;

	public GameObject compCar3;

	public ekranGoruntuleri ekranTus;

	public kilit yeniKilit;

	public bool sureGeldi;

	public bool aracEklendi;

	public arabaEkle()
	{
		camTakipEt = false;
		sureGeldi = false;
		aracEklendi = false;
	}

	public void Awake()
	{
		ekranTuslari ekranTuslari2 = (ekranTuslari)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranTuslari));
		oyuncuSec oyuncuSec2 = (oyuncuSec)(object)UnityEngine.Object.FindObjectOfType(typeof(oyuncuSec));
		UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)ekranTuslari2);
		UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object)(object)oyuncuSec2);
	}

	public void Start()
	{
		soruGetir = (soruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(soruEkrani));
		soruGetirSonu = (oyunSonuSoruEkrani)(object)UnityEngine.Object.FindObjectOfType(typeof(oyunSonuSoruEkrani));
		aracHasarAc = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
		compCar1 = GameObject.Find("ComputerCar1");
		compCar2 = GameObject.Find("ComputerCar2");
		compCar3 = GameObject.Find("ComputerCar3");
		ekranTus = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
		ekranTuslari ekranTuslari2 = (ekranTuslari)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranTuslari));
		oyuncuSec oyuncuSec2 = (oyuncuSec)(object)UnityEngine.Object.FindObjectOfType(typeof(oyuncuSec));
		ekranTus.siralamaKapat(1);
		((MonoBehaviour)ekranTus).StartCoroutine_Auto(ekranTus.aracSecimKapat(ekranTuslari.aracSecim));
		secilenArac = ekranTuslari.aracSecim;
		yeniKilit = (kilit)(object)UnityEngine.Object.FindObjectOfType(typeof(kilit));
	}

	public IEnumerator sureTut()
	{
		return new sureTut_002447(this).GetEnumerator();
	}

	public void arabaDegistir(int param)
	{
		switch (param)
		{
		case 1:
			if (soruGetir.dogruCevapSay == 0)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec, new Vector3(7.5f, 16f, -5f), ((Component)this).transform.rotation);
			}
			else if (soruGetir.dogruCevapSay == 1)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec, new Vector3(compCar3.transform.position.x, compCar3.transform.position.y, compCar3.transform.position.z), ((Component)this).transform.rotation);
				float x9 = 7.5f;
				Vector3 position55 = compCar3.transform.position;
				float num91 = (position55.x = x9);
				Vector3 val110 = (compCar3.transform.position = position55);
				int num92 = 16;
				Vector3 position56 = compCar3.transform.position;
				float num93 = (position56.y = num92);
				Vector3 val112 = (compCar3.transform.position = position56);
				int num94 = -5;
				Vector3 position57 = compCar3.transform.position;
				float num95 = (position57.z = num94);
				Vector3 val114 = (compCar3.transform.position = position57);
			}
			else if (soruGetir.dogruCevapSay == 2)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec, new Vector3(compCar2.transform.position.x, compCar2.transform.position.y, compCar2.transform.position.z), ((Component)this).transform.rotation);
				int num96 = 2;
				Vector3 position58 = compCar2.transform.position;
				float num97 = (position58.x = num96);
				Vector3 val116 = (compCar2.transform.position = position58);
				float y11 = 15.62744f;
				Vector3 position59 = compCar2.transform.position;
				float num98 = (position59.y = y11);
				Vector3 val118 = (compCar2.transform.position = position59);
				int num99 = 3;
				Vector3 position60 = compCar2.transform.position;
				float num100 = (position60.z = num99);
				Vector3 val120 = (compCar2.transform.position = position60);
				float x10 = 7.5f;
				Vector3 position61 = compCar3.transform.position;
				float num101 = (position61.x = x10);
				Vector3 val122 = (compCar3.transform.position = position61);
				int num102 = 16;
				Vector3 position62 = compCar3.transform.position;
				float num103 = (position62.y = num102);
				Vector3 val124 = (compCar3.transform.position = position62);
				int num104 = -5;
				Vector3 position63 = compCar3.transform.position;
				float num105 = (position63.z = num104);
				Vector3 val126 = (compCar3.transform.position = position63);
			}
			else if (soruGetir.dogruCevapSay == 3)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num106 = -3;
				Vector3 position64 = compCar1.transform.position;
				float num107 = (position64.x = num106);
				Vector3 val128 = (compCar1.transform.position = position64);
				float y12 = 15.62744f;
				Vector3 position65 = compCar1.transform.position;
				float num108 = (position65.y = y12);
				Vector3 val130 = (compCar1.transform.position = position65);
				int num109 = 11;
				Vector3 position66 = compCar1.transform.position;
				float num110 = (position66.z = num109);
				Vector3 val132 = (compCar1.transform.position = position66);
				int num111 = 2;
				Vector3 position67 = compCar2.transform.position;
				float num112 = (position67.x = num111);
				Vector3 val134 = (compCar2.transform.position = position67);
				float y13 = 15.62744f;
				Vector3 position68 = compCar2.transform.position;
				float num113 = (position68.y = y13);
				Vector3 val136 = (compCar2.transform.position = position68);
				int num114 = 3;
				Vector3 position69 = compCar2.transform.position;
				float num115 = (position69.z = num114);
				Vector3 val138 = (compCar2.transform.position = position69);
				float x11 = 7.5f;
				Vector3 position70 = compCar3.transform.position;
				float num116 = (position70.x = x11);
				Vector3 val140 = (compCar3.transform.position = position70);
				int num117 = 16;
				Vector3 position71 = compCar3.transform.position;
				float num118 = (position71.y = num117);
				Vector3 val142 = (compCar3.transform.position = position71);
				int num119 = -5;
				Vector3 position72 = compCar3.transform.position;
				float num120 = (position72.z = num119);
				Vector3 val144 = (compCar3.transform.position = position72);
			}
			else if (soruGetir.dogruCevapSay == 4)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num121 = -3;
				Vector3 position73 = compCar1.transform.position;
				float num122 = (position73.x = num121);
				Vector3 val146 = (compCar1.transform.position = position73);
				float y14 = 15.62744f;
				Vector3 position74 = compCar1.transform.position;
				float num123 = (position74.y = y14);
				Vector3 val148 = (compCar1.transform.position = position74);
				int num124 = 11;
				Vector3 position75 = compCar1.transform.position;
				float num125 = (position75.z = num124);
				Vector3 val150 = (compCar1.transform.position = position75);
				int num126 = 2;
				Vector3 position76 = compCar2.transform.position;
				float num127 = (position76.x = num126);
				Vector3 val152 = (compCar2.transform.position = position76);
				float y15 = 15.62744f;
				Vector3 position77 = compCar2.transform.position;
				float num128 = (position77.y = y15);
				Vector3 val154 = (compCar2.transform.position = position77);
				int num129 = 3;
				Vector3 position78 = compCar2.transform.position;
				float num130 = (position78.z = num129);
				Vector3 val156 = (compCar2.transform.position = position78);
				float x12 = 7.5f;
				Vector3 position79 = compCar3.transform.position;
				float num131 = (position79.x = x12);
				Vector3 val158 = (compCar3.transform.position = position79);
				int num132 = 16;
				Vector3 position80 = compCar3.transform.position;
				float num133 = (position80.y = num132);
				Vector3 val160 = (compCar3.transform.position = position80);
				int num134 = -5;
				Vector3 position81 = compCar3.transform.position;
				float num135 = (position81.z = num134);
				Vector3 val162 = (compCar3.transform.position = position81);
			}
			PlayerCar_Script.secilenAraba = 1;
			camTakipEt = true;
			break;
		case 2:
			if (soruGetir.dogruCevapSay == 0)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec2, new Vector3(7.5f, 16f, -5f), ((Component)this).transform.rotation);
			}
			else if (soruGetir.dogruCevapSay == 1)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec2, new Vector3(compCar3.transform.position.x, compCar3.transform.position.y, compCar3.transform.position.z), ((Component)this).transform.rotation);
				float x5 = 7.5f;
				Vector3 position28 = compCar3.transform.position;
				float num46 = (position28.x = x5);
				Vector3 val56 = (compCar3.transform.position = position28);
				int num47 = 16;
				Vector3 position29 = compCar3.transform.position;
				float num48 = (position29.y = num47);
				Vector3 val58 = (compCar3.transform.position = position29);
				int num49 = -5;
				Vector3 position30 = compCar3.transform.position;
				float num50 = (position30.z = num49);
				Vector3 val60 = (compCar3.transform.position = position30);
			}
			else if (soruGetir.dogruCevapSay == 2)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec2, new Vector3(compCar2.transform.position.x, compCar2.transform.position.y, compCar2.transform.position.z), ((Component)this).transform.rotation);
				int num51 = 2;
				Vector3 position31 = compCar2.transform.position;
				float num52 = (position31.x = num51);
				Vector3 val62 = (compCar2.transform.position = position31);
				float y6 = 15.62744f;
				Vector3 position32 = compCar2.transform.position;
				float num53 = (position32.y = y6);
				Vector3 val64 = (compCar2.transform.position = position32);
				int num54 = 3;
				Vector3 position33 = compCar2.transform.position;
				float num55 = (position33.z = num54);
				Vector3 val66 = (compCar2.transform.position = position33);
				float x6 = 7.5f;
				Vector3 position34 = compCar3.transform.position;
				float num56 = (position34.x = x6);
				Vector3 val68 = (compCar3.transform.position = position34);
				int num57 = 16;
				Vector3 position35 = compCar3.transform.position;
				float num58 = (position35.y = num57);
				Vector3 val70 = (compCar3.transform.position = position35);
				int num59 = -5;
				Vector3 position36 = compCar3.transform.position;
				float num60 = (position36.z = num59);
				Vector3 val72 = (compCar3.transform.position = position36);
			}
			else if (soruGetir.dogruCevapSay == 3)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec2, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num61 = -3;
				Vector3 position37 = compCar1.transform.position;
				float num62 = (position37.x = num61);
				Vector3 val74 = (compCar1.transform.position = position37);
				float y7 = 15.62744f;
				Vector3 position38 = compCar1.transform.position;
				float num63 = (position38.y = y7);
				Vector3 val76 = (compCar1.transform.position = position38);
				int num64 = 11;
				Vector3 position39 = compCar1.transform.position;
				float num65 = (position39.z = num64);
				Vector3 val78 = (compCar1.transform.position = position39);
				int num66 = 2;
				Vector3 position40 = compCar2.transform.position;
				float num67 = (position40.x = num66);
				Vector3 val80 = (compCar2.transform.position = position40);
				float y8 = 15.62744f;
				Vector3 position41 = compCar2.transform.position;
				float num68 = (position41.y = y8);
				Vector3 val82 = (compCar2.transform.position = position41);
				int num69 = 3;
				Vector3 position42 = compCar2.transform.position;
				float num70 = (position42.z = num69);
				Vector3 val84 = (compCar2.transform.position = position42);
				float x7 = 7.5f;
				Vector3 position43 = compCar3.transform.position;
				float num71 = (position43.x = x7);
				Vector3 val86 = (compCar3.transform.position = position43);
				int num72 = 16;
				Vector3 position44 = compCar3.transform.position;
				float num73 = (position44.y = num72);
				Vector3 val88 = (compCar3.transform.position = position44);
				int num74 = -5;
				Vector3 position45 = compCar3.transform.position;
				float num75 = (position45.z = num74);
				Vector3 val90 = (compCar3.transform.position = position45);
			}
			else if (soruGetir.dogruCevapSay == 4)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec2, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num76 = -3;
				Vector3 position46 = compCar1.transform.position;
				float num77 = (position46.x = num76);
				Vector3 val92 = (compCar1.transform.position = position46);
				float y9 = 15.62744f;
				Vector3 position47 = compCar1.transform.position;
				float num78 = (position47.y = y9);
				Vector3 val94 = (compCar1.transform.position = position47);
				int num79 = 11;
				Vector3 position48 = compCar1.transform.position;
				float num80 = (position48.z = num79);
				Vector3 val96 = (compCar1.transform.position = position48);
				int num81 = 2;
				Vector3 position49 = compCar2.transform.position;
				float num82 = (position49.x = num81);
				Vector3 val98 = (compCar2.transform.position = position49);
				float y10 = 15.62744f;
				Vector3 position50 = compCar2.transform.position;
				float num83 = (position50.y = y10);
				Vector3 val100 = (compCar2.transform.position = position50);
				int num84 = 3;
				Vector3 position51 = compCar2.transform.position;
				float num85 = (position51.z = num84);
				Vector3 val102 = (compCar2.transform.position = position51);
				float x8 = 7.5f;
				Vector3 position52 = compCar3.transform.position;
				float num86 = (position52.x = x8);
				Vector3 val104 = (compCar3.transform.position = position52);
				int num87 = 16;
				Vector3 position53 = compCar3.transform.position;
				float num88 = (position53.y = num87);
				Vector3 val106 = (compCar3.transform.position = position53);
				int num89 = -5;
				Vector3 position54 = compCar3.transform.position;
				float num90 = (position54.z = num89);
				Vector3 val108 = (compCar3.transform.position = position54);
			}
			PlayerCar_Script.secilenAraba = 2;
			camTakipEt = true;
			break;
		case 3:
			if (soruGetir.dogruCevapSay == 0)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec3, new Vector3(7.5f, 16f, -5f), ((Component)this).transform.rotation);
			}
			else if (soruGetir.dogruCevapSay == 1)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec3, new Vector3(compCar3.transform.position.x, compCar3.transform.position.y, compCar3.transform.position.z), ((Component)this).transform.rotation);
				float x13 = 7.5f;
				Vector3 position82 = compCar3.transform.position;
				float num136 = (position82.x = x13);
				Vector3 val164 = (compCar3.transform.position = position82);
				int num137 = 16;
				Vector3 position83 = compCar3.transform.position;
				float num138 = (position83.y = num137);
				Vector3 val166 = (compCar3.transform.position = position83);
				int num139 = -5;
				Vector3 position84 = compCar3.transform.position;
				float num140 = (position84.z = num139);
				Vector3 val168 = (compCar3.transform.position = position84);
			}
			else if (soruGetir.dogruCevapSay == 2)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec3, new Vector3(compCar2.transform.position.x, compCar2.transform.position.y, compCar2.transform.position.z), ((Component)this).transform.rotation);
				int num141 = 2;
				Vector3 position85 = compCar2.transform.position;
				float num142 = (position85.x = num141);
				Vector3 val170 = (compCar2.transform.position = position85);
				float y16 = 15.62744f;
				Vector3 position86 = compCar2.transform.position;
				float num143 = (position86.y = y16);
				Vector3 val172 = (compCar2.transform.position = position86);
				int num144 = 3;
				Vector3 position87 = compCar2.transform.position;
				float num145 = (position87.z = num144);
				Vector3 val174 = (compCar2.transform.position = position87);
				float x14 = 7.5f;
				Vector3 position88 = compCar3.transform.position;
				float num146 = (position88.x = x14);
				Vector3 val176 = (compCar3.transform.position = position88);
				int num147 = 16;
				Vector3 position89 = compCar3.transform.position;
				float num148 = (position89.y = num147);
				Vector3 val178 = (compCar3.transform.position = position89);
				int num149 = -5;
				Vector3 position90 = compCar3.transform.position;
				float num150 = (position90.z = num149);
				Vector3 val180 = (compCar3.transform.position = position90);
			}
			else if (soruGetir.dogruCevapSay == 3)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec3, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num151 = -3;
				Vector3 position91 = compCar1.transform.position;
				float num152 = (position91.x = num151);
				Vector3 val182 = (compCar1.transform.position = position91);
				float y17 = 15.62744f;
				Vector3 position92 = compCar1.transform.position;
				float num153 = (position92.y = y17);
				Vector3 val184 = (compCar1.transform.position = position92);
				int num154 = 11;
				Vector3 position93 = compCar1.transform.position;
				float num155 = (position93.z = num154);
				Vector3 val186 = (compCar1.transform.position = position93);
				int num156 = 2;
				Vector3 position94 = compCar2.transform.position;
				float num157 = (position94.x = num156);
				Vector3 val188 = (compCar2.transform.position = position94);
				float y18 = 15.62744f;
				Vector3 position95 = compCar2.transform.position;
				float num158 = (position95.y = y18);
				Vector3 val190 = (compCar2.transform.position = position95);
				int num159 = 3;
				Vector3 position96 = compCar2.transform.position;
				float num160 = (position96.z = num159);
				Vector3 val192 = (compCar2.transform.position = position96);
				float x15 = 7.5f;
				Vector3 position97 = compCar3.transform.position;
				float num161 = (position97.x = x15);
				Vector3 val194 = (compCar3.transform.position = position97);
				int num162 = 16;
				Vector3 position98 = compCar3.transform.position;
				float num163 = (position98.y = num162);
				Vector3 val196 = (compCar3.transform.position = position98);
				int num164 = -5;
				Vector3 position99 = compCar3.transform.position;
				float num165 = (position99.z = num164);
				Vector3 val198 = (compCar3.transform.position = position99);
			}
			else if (soruGetir.dogruCevapSay == 4)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec3, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num166 = -3;
				Vector3 position100 = compCar1.transform.position;
				float num167 = (position100.x = num166);
				Vector3 val200 = (compCar1.transform.position = position100);
				float y19 = 15.62744f;
				Vector3 position101 = compCar1.transform.position;
				float num168 = (position101.y = y19);
				Vector3 val202 = (compCar1.transform.position = position101);
				int num169 = 11;
				Vector3 position102 = compCar1.transform.position;
				float num170 = (position102.z = num169);
				Vector3 val204 = (compCar1.transform.position = position102);
				int num171 = 2;
				Vector3 position103 = compCar2.transform.position;
				float num172 = (position103.x = num171);
				Vector3 val206 = (compCar2.transform.position = position103);
				float y20 = 15.62744f;
				Vector3 position104 = compCar2.transform.position;
				float num173 = (position104.y = y20);
				Vector3 val208 = (compCar2.transform.position = position104);
				int num174 = 3;
				Vector3 position105 = compCar2.transform.position;
				float num175 = (position105.z = num174);
				Vector3 val210 = (compCar2.transform.position = position105);
				float x16 = 7.5f;
				Vector3 position106 = compCar3.transform.position;
				float num176 = (position106.x = x16);
				Vector3 val212 = (compCar3.transform.position = position106);
				int num177 = 16;
				Vector3 position107 = compCar3.transform.position;
				float num178 = (position107.y = num177);
				Vector3 val214 = (compCar3.transform.position = position107);
				int num179 = -5;
				Vector3 position108 = compCar3.transform.position;
				float num180 = (position108.z = num179);
				Vector3 val216 = (compCar3.transform.position = position108);
			}
			PlayerCar_Script.secilenAraba = 3;
			camTakipEt = true;
			break;
		case 4:
			if (soruGetir.dogruCevapSay == 0)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec4, new Vector3(7.5f, 16f, -5f), ((Component)this).transform.rotation);
			}
			else if (soruGetir.dogruCevapSay == 1)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec4, new Vector3(compCar3.transform.position.x, compCar3.transform.position.y, compCar3.transform.position.z), ((Component)this).transform.rotation);
				float x = 7.5f;
				Vector3 position = compCar3.transform.position;
				float num = (position.x = x);
				Vector3 val2 = (compCar3.transform.position = position);
				int num2 = 16;
				Vector3 position2 = compCar3.transform.position;
				float num3 = (position2.y = num2);
				Vector3 val4 = (compCar3.transform.position = position2);
				int num4 = -5;
				Vector3 position3 = compCar3.transform.position;
				float num5 = (position3.z = num4);
				Vector3 val6 = (compCar3.transform.position = position3);
			}
			else if (soruGetir.dogruCevapSay == 2)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec4, new Vector3(compCar2.transform.position.x, compCar2.transform.position.y, compCar2.transform.position.z), ((Component)this).transform.rotation);
				int num6 = 2;
				Vector3 position4 = compCar2.transform.position;
				float num7 = (position4.x = num6);
				Vector3 val8 = (compCar2.transform.position = position4);
				float y = 15.62744f;
				Vector3 position5 = compCar2.transform.position;
				float num8 = (position5.y = y);
				Vector3 val10 = (compCar2.transform.position = position5);
				int num9 = 3;
				Vector3 position6 = compCar2.transform.position;
				float num10 = (position6.z = num9);
				Vector3 val12 = (compCar2.transform.position = position6);
				float x2 = 7.5f;
				Vector3 position7 = compCar3.transform.position;
				float num11 = (position7.x = x2);
				Vector3 val14 = (compCar3.transform.position = position7);
				int num12 = 16;
				Vector3 position8 = compCar3.transform.position;
				float num13 = (position8.y = num12);
				Vector3 val16 = (compCar3.transform.position = position8);
				int num14 = -5;
				Vector3 position9 = compCar3.transform.position;
				float num15 = (position9.z = num14);
				Vector3 val18 = (compCar3.transform.position = position9);
			}
			else if (soruGetir.dogruCevapSay == 3)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec4, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num16 = -3;
				Vector3 position10 = compCar1.transform.position;
				float num17 = (position10.x = num16);
				Vector3 val20 = (compCar1.transform.position = position10);
				float y2 = 15.62744f;
				Vector3 position11 = compCar1.transform.position;
				float num18 = (position11.y = y2);
				Vector3 val22 = (compCar1.transform.position = position11);
				int num19 = 11;
				Vector3 position12 = compCar1.transform.position;
				float num20 = (position12.z = num19);
				Vector3 val24 = (compCar1.transform.position = position12);
				int num21 = 2;
				Vector3 position13 = compCar2.transform.position;
				float num22 = (position13.x = num21);
				Vector3 val26 = (compCar2.transform.position = position13);
				float y3 = 15.62744f;
				Vector3 position14 = compCar2.transform.position;
				float num23 = (position14.y = y3);
				Vector3 val28 = (compCar2.transform.position = position14);
				int num24 = 3;
				Vector3 position15 = compCar2.transform.position;
				float num25 = (position15.z = num24);
				Vector3 val30 = (compCar2.transform.position = position15);
				float x3 = 7.5f;
				Vector3 position16 = compCar3.transform.position;
				float num26 = (position16.x = x3);
				Vector3 val32 = (compCar3.transform.position = position16);
				int num27 = 16;
				Vector3 position17 = compCar3.transform.position;
				float num28 = (position17.y = num27);
				Vector3 val34 = (compCar3.transform.position = position17);
				int num29 = -5;
				Vector3 position18 = compCar3.transform.position;
				float num30 = (position18.z = num29);
				Vector3 val36 = (compCar3.transform.position = position18);
			}
			else if (soruGetir.dogruCevapSay == 4)
			{
				yeniaraba = (Transform)UnityEngine.Object.Instantiate((UnityEngine.Object)(object)arabaSec4, new Vector3(compCar1.transform.position.x, compCar1.transform.position.y, compCar1.transform.position.z), ((Component)this).transform.rotation);
				int num31 = -3;
				Vector3 position19 = compCar1.transform.position;
				float num32 = (position19.x = num31);
				Vector3 val38 = (compCar1.transform.position = position19);
				float y4 = 15.62744f;
				Vector3 position20 = compCar1.transform.position;
				float num33 = (position20.y = y4);
				Vector3 val40 = (compCar1.transform.position = position20);
				int num34 = 11;
				Vector3 position21 = compCar1.transform.position;
				float num35 = (position21.z = num34);
				Vector3 val42 = (compCar1.transform.position = position21);
				int num36 = 2;
				Vector3 position22 = compCar2.transform.position;
				float num37 = (position22.x = num36);
				Vector3 val44 = (compCar2.transform.position = position22);
				float y5 = 15.62744f;
				Vector3 position23 = compCar2.transform.position;
				float num38 = (position23.y = y5);
				Vector3 val46 = (compCar2.transform.position = position23);
				int num39 = 3;
				Vector3 position24 = compCar2.transform.position;
				float num40 = (position24.z = num39);
				Vector3 val48 = (compCar2.transform.position = position24);
				float x4 = 7.5f;
				Vector3 position25 = compCar3.transform.position;
				float num41 = (position25.x = x4);
				Vector3 val50 = (compCar3.transform.position = position25);
				int num42 = 16;
				Vector3 position26 = compCar3.transform.position;
				float num43 = (position26.y = num42);
				Vector3 val52 = (compCar3.transform.position = position26);
				int num44 = -5;
				Vector3 position27 = compCar3.transform.position;
				float num45 = (position27.z = num44);
				Vector3 val54 = (compCar3.transform.position = position27);
			}
			PlayerCar_Script.secilenAraba = 4;
			camTakipEt = true;
			break;
		}
	}

	public void Update()
	{
		if (soruGetir.araciEkle)
		{
			aracEklendi = true;
			arabaDegistir(secilenArac);
			soruGetir.araciEkle = false;
		}
		if (camTakipEt)
		{
			SmoothFollow smoothFollow = (SmoothFollow)(object)UnityEngine.Object.FindObjectOfType(typeof(SmoothFollow));
			smoothFollow.target = ((Component)yeniaraba).transform;
		}
		if (!sureGeldi)
		{
			((MonoBehaviour)this).StartCoroutine_Auto(sureTut());
		}
		if (ekranTus.suregoster)
		{
			return;
		}
		checked
		{
			if (ekranTus.soruSec && sureGeldi && !yeniKilit.soruTusKilit)
			{
				if (Input.GetButtonUp("Fire2") || Input.GetKeyUp("a"))
				{
					if (soruGetir.soruBasi)
					{
						yeniKilit.soruTusKilit = true;
						if (soruGetir.soruKac + 1 < soruGetir.SorularJ.length - 1)
						{
							if (soruGetir.sec < 5)
							{
								((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: true, "a"));
							}
							else
							{
								((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: false, "a"));
							}
						}
						else
						{
							if (soruGetir.sec < 5)
							{
								((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: true, "a"));
							}
							else
							{
								((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: false, "a"));
							}
							aracEklendi = true;
							arabaDegistir(secilenArac);
							((MonoBehaviour)yeniKilit).StartCoroutine_Auto(yeniKilit.baslat());
						}
					}
				}
				else if ((Input.GetButtonUp("Fire1") || Input.GetKeyUp("b")) && soruGetir.soruBasi)
				{
					yeniKilit.soruTusKilit = true;
					if (soruGetir.soruKac + 1 < soruGetir.SorularJ.length - 1)
					{
						if (soruGetir.sec < 5)
						{
							((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: false, "b"));
						}
						else
						{
							((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: true, "b"));
						}
					}
					else
					{
						if (soruGetir.sec < 5)
						{
							((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: false, "b"));
						}
						else
						{
							((MonoBehaviour)soruGetir).StartCoroutine_Auto(soruGetir.soruKontrol(cevap: true, "b"));
						}
						aracEklendi = true;
						arabaDegistir(secilenArac);
						((MonoBehaviour)yeniKilit).StartCoroutine_Auto(yeniKilit.baslat());
					}
				}
			}
			if (ekranGoruntuleri.tusKilidi)
			{
				return;
			}
			if (Input.GetKeyUp("1"))
			{
				if (ekranTus.siralamaGoster)
				{
					ekranTus.siralamaKapat(1);
				}
				else
				{
					((MonoBehaviour)ekranTus).StartCoroutine_Auto(ekranTus.aracSecimKapat(1));
					secilenArac = 1;
				}
			}
			if (Input.GetKeyUp("2"))
			{
				if (ekranTus.siralamaGoster)
				{
					ekranTus.siralamaKapat(2);
				}
				else
				{
					((MonoBehaviour)ekranTus).StartCoroutine_Auto(ekranTus.aracSecimKapat(2));
					secilenArac = 2;
				}
			}
			if (Input.GetKeyUp("3"))
			{
				if (ekranTus.siralamaGoster)
				{
					ekranTus.siralamaKapat(3);
				}
				else
				{
					((MonoBehaviour)ekranTus).StartCoroutine_Auto(ekranTus.aracSecimKapat(3));
					secilenArac = 3;
				}
			}
			if (Input.GetKeyUp("4"))
			{
				if (ekranTus.siralamaGoster)
				{
					ekranTus.siralamaKapat(4);
					return;
				}
				((MonoBehaviour)ekranTus).StartCoroutine_Auto(ekranTus.aracSecimKapat(4));
				secilenArac = 4;
			}
		}
	}

	public void Main()
	{
	}
}
