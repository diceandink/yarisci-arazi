using System;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class oyuncuSec : MonoBehaviour
{
	public GUIStyle customGuiStyle_logo;

	public GUIStyle oyuncuSirala;

	public static UnityScript.Lang.Array oyuncular = new UnityScript.Lang.Array();

	public static int secilenOyuncu;

	public static int turModu;

	public static bool turSecim = true;

	public void isimleriAl(string[] isimler)
	{
		for (int i = 0; i < ((isimler).Length); i = checked(i + 1))
		{
			oyuncular[i] = isimler[RuntimeServices.NormalizeArrayIndex((System.Array)isimler, i)];
		}
	}

	public void sahneYukle(int deger)
	{
		secilenOyuncu = deger;
		Application.LoadLevel("aracMenu");
	}

	public void turSectir()
	{
		((Component)this).gameObject.SendMessage("xmlSirasiAyarla", (object)turModu);
	}

	public void Start()
	{
		Screen.showCursor = false;
		Time.timeScale = 1f;
		turSecim = true;
	}

	public void Update()
	{
		if (Input.GetKeyUp("j"))
		{
			Application.LoadLevel("siralamaEkrani");
		}
		if (turSecim)
		{
			if (Input.GetKeyUp("1"))
			{
				turModu = 1;
				turSectir();
				turSecim = false;
			}
			if (Input.GetKeyUp("2"))
			{
				turModu = 2;
				turSectir();
				turSecim = false;
			}
			return;
		}
		if (Input.GetKeyUp("1"))
		{
			sahneYukle(0);
		}
		if (Input.GetKeyUp("2"))
		{
			sahneYukle(1);
		}
		if (Input.GetKeyUp("3"))
		{
			sahneYukle(2);
		}
		if (Input.GetKeyUp("4"))
		{
			sahneYukle(3);
		}
	}

	public void OnGUI()
	{
		checked
		{
			if (turSecim)
			{
				if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 350), 100f, 771f, 81f), "1. Tur Sec ", oyuncuSirala))
				{
				}
				if (!GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 350), 185f, 771f, 81f), "2. Tur Sec", oyuncuSirala))
				{
				}
			}
			else if (turModu == 1)
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
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"4    ", oyuncular[3]),
					oyuncuSirala
				})))
				{
				}
			}
			else if (turModu == 2)
			{
				if (RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeof(GUI), "Button", new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 350), 100f, 771f, 81f),
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"1     ", oyuncular[0]),
					oyuncuSirala
				})))
				{
				}
				if (!RuntimeServices.ToBool(RuntimeServices.Invoke((object)typeof(GUI), "Button", new object[3]
				{
					(object)new Rect((float)(unchecked(Screen.width / 2) - 350), 185f, 771f, 81f),
					RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"2     ", oyuncular[1]),
					oyuncuSirala
				})))
				{
				}
			}
		}
	}

	public void Main()
	{
	}
}
