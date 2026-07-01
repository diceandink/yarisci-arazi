using System;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class Oyuncu : MonoBehaviour
{
	public string kullaniciAdi;

	public string sifre;

	public string toplamSure;

	public string eksilenSure;

	public string dusurulmusSure;

	public string topladigiKumSaati;

	public string topladigiTurbo;

	public string topladigiSoruIsareti;

	private float sesDuzeyi;

	public int muzikDuzeyi;

	public UnityScript.Lang.Array kalite;

	public GUIStyle menu1;

	public GUIStyle menu2;

	public GUIStyle menu3;

	public GUIStyle menu4;

	public GUIStyle nasilO;

	public GUIStyle anaMenu;

	public GUIStyle[] goruntuK;

	public GUIStyle[] sesK;

	public GUIStyle onayla;

	public GUIStyle iptal;

	public static int degerG = 2;

	public static int degerS = 3;

	public GUIStyle arti;

	public GUIStyle eksi;

	public int secimSahne;

	public GUIStyle logoHolder;

	public GUIStyle menubg;

	public AudioSource buttonHover;

	public AudioSource buttonClick;

	public bool calar1;

	public bool calar2;

	public bool calar3;

	public bool calar4;

	public Oyuncu()
	{
		sesDuzeyi = 1f;
		kalite = new UnityScript.Lang.Array(new object[3] { "dusuk", "orta", "yuksek" });
		secimSahne = 1;
		calar1 = false;
		calar2 = false;
		calar3 = false;
		calar4 = false;
	}

	public void Start()
	{
		string pathMenu = Application.dataPath + "/menu_bg.png";
		if (System.IO.File.Exists(pathMenu))
		{
			byte[] bytesMenu = System.IO.File.ReadAllBytes(pathMenu);
			Texture2D texMenu = new Texture2D(2, 2);
			texMenu.LoadImage(bytesMenu);
			menubg.normal.background = texMenu;
		}
	}

	public void calarF(int num)
	{
		switch (num)
		{
		case 1:
			if (!calar1)
			{
				buttonHover.Play();
				calar1 = true;
			}
			break;
		case 2:
			if (!calar2)
			{
				buttonHover.Play();
				calar2 = true;
			}
			break;
		case 3:
			if (!calar3)
			{
				buttonHover.Play();
				calar3 = true;
			}
			break;
		case 4:
			if (!calar4)
			{
				buttonHover.Play();
				calar4 = true;
			}
			break;
		}
	}

	public void OnGUI()
	{
		checked
		{
			GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 400), (float)(unchecked(Screen.height / 2) - 300), 800f, 600f), string.Empty, menubg);
			if (secimSahne == 1)
			{
				Rect val = new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) + 5), 400f, 58f);
				if (val.Contains(Input.mousePosition))
				{
					calarF(1);
				}
				else
				{
					calar1 = false;
				}
				Rect val2 = new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) - 60), 400f, 58f);
				if (val2.Contains(Input.mousePosition))
				{
					calarF(2);
				}
				else
				{
					calar2 = false;
				}
				Rect val3 = new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) - 130), 400f, 58f);
				if (val3.Contains(Input.mousePosition))
				{
					calarF(3);
					MonoBehaviour.print((object)"3");
				}
				else
				{
					calar3 = false;
				}
				Rect val4 = new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) - 190), 400f, 58f);
				if (val4.Contains(Input.mousePosition))
				{
					calarF(4);
				}
				else
				{
					calar4 = false;
				}
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 180), 20f, 360f, 203f), string.Empty, logoHolder);
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) - 60), 400f, 58f), string.Empty, menu1))
				{
					buttonClick.Play();
					while (!Application.CanStreamedLevelBeLoaded("aracSecim"))
					{
					}
					Application.LoadLevel("aracSecim");
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) + 5), 400f, 58f), string.Empty, menu2))
				{
					buttonClick.Play();
					secimSahne = 2;
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) + 70), 400f, 58f), string.Empty, menu3))
				{
					buttonClick.Play();
					secimSahne = 3;
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 200), (float)(unchecked(Screen.height / 2) + 135), 400f, 58f), string.Empty, menu4))
				{
					buttonClick.Play();
					Application.ExternalCall("MM_openBrWindow", new object[3] { "skorlar.aspx", "Skorlar", "scrollbars=yes,width=1005,height=600" });
				}
			}
			else if (secimSahne == 2)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 180), 20f, 360f, 203f), string.Empty, logoHolder);
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 221), (float)(unchecked(Screen.height / 2) - 5), 48f, 49f), string.Empty, arti))
				{
					buttonClick.Play();
					if (degerG < 2)
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
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) - 5), 48f, 49f), string.Empty, eksi))
				{
					buttonClick.Play();
					if (degerG > 0)
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
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 221), (float)(unchecked(Screen.height / 2) + 100), 48f, 49f), string.Empty, arti))
				{
					buttonClick.Play();
					if (degerS < 5)
					{
						degerS++;
						sesDuzeyi += 0.2f;
						AudioListener.volume = sesDuzeyi;
					}
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 280), (float)(unchecked(Screen.height / 2) + 100), 48f, 49f), string.Empty, eksi))
				{
					buttonClick.Play();
					if (degerS > 0)
					{
						degerS--;
						sesDuzeyi -= 0.2f;
						AudioListener.volume = sesDuzeyi;
					}
				}
				Rect val5 = new Rect((float)(unchecked(Screen.width / 2) - 221), (float)(unchecked(Screen.height / 2) - 46), 422f, 93f);
				string empty = string.Empty;
				GUIStyle[] array = goruntuK;
				GUI.Label(val5, empty, array[RuntimeServices.NormalizeArrayIndex((System.Array)array, degerG)]);
				Rect val6 = new Rect((float)(unchecked(Screen.width / 2) - 221), (float)(unchecked(Screen.height / 2) + 59), 422f, 93f);
				string empty2 = string.Empty;
				GUIStyle[] array2 = sesK;
				GUI.Label(val6, empty2, array2[RuntimeServices.NormalizeArrayIndex((System.Array)array2, degerS)]);
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 116), (float)(unchecked(Screen.height / 2) + 180), 116f, 43f), string.Empty, onayla))
				{
					buttonClick.Play();
					secimSahne = 1;
				}
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) + 10), (float)(unchecked(Screen.height / 2) + 180), 116f, 43f), string.Empty, iptal))
				{
					buttonClick.Play();
					sesDuzeyi = 60f;
					degerG = 0;
					degerS = 3;
					_ = kalite[0];
					secimSahne = 1;
				}
			}
			else if (secimSahne == 3)
			{
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 310), (float)(unchecked(Screen.height / 2) - 220), 170f, 44f), string.Empty, anaMenu))
				{
					buttonClick.Play();
					secimSahne = 1;
				}
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 340), (float)(unchecked(Screen.height / 2) - 170), 680f, 440f), string.Empty, nasilO);
			}
		}
	}

	public void Main()
	{
	}
}
