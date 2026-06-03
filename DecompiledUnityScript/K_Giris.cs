using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class K_Giris : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class girisYap_002441 : GenericGenerator<WWW>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WWW>, IEnumerator
		{
			internal string _0024url_0024330;

			internal WWW _0024www_0024331;

			internal string _0024cevap_0024332;

			internal string _0024username333;

			internal string _0024password334;

			public _0024(string username, string password)
			{
				_0024username333 = username;
				_0024password334 = password;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024url_0024330 = "http://www.trt.net.tr/trtcocuk/yarisci/kullanicigiris.aspx?kullanici=" + _0024username333 + "&sifre=" + _0024password334;
					_0024www_0024331 = new WWW(_0024url_0024330);
					return base.Yield(2, _0024www_0024331);
				case 2:
					_0024cevap_0024332 = _0024www_0024331.data;
					if (!_0024cevap_0024332.Contains("true"))
					{
					}
					while (!Application.CanStreamedLevelBeLoaded("OyunMenu"))
					{
					}
					Application.LoadLevel("OyunMenu");
					durum = true;
					base.Yield(1, (WWW)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal string _0024username335;

		internal string _0024password336;

		public girisYap_002441(string username, string password)
		{
			_0024username335 = username;
			_0024password336 = password;
		}

		public override IEnumerator<WWW> GetEnumerator()
		{
			return (IEnumerator<WWW>)(object)new _0024(_0024username335, _0024password336);
		}
	}

	public static string kullaniciAdi = string.Empty;

	public string sifre;

	public GUIStyle menu1;

	public GUIStyle menu2;

	public GUIStyle gonderBut;

	public GUIStyle logoHolder;

	public GUIStyle menubg;

	public GUIStyle kullaniciGirBg;

	public GUIStyle inputStil;

	public GUIStyle hataStil;

	public AudioSource gonderSes;

	public static bool durum = true;

	public static bool gonderi = false;

	public K_Giris()
	{
		sifre = string.Empty;
	}

	public IEnumerator girisYap(string username, string password)
	{
		Application.LoadLevel("OyunMenu");
		durum = true;
		yield return null;
	}

	public void Update()
	{
		if (Input.GetKeyUp((KeyCode)13))
		{
			gonderi = true;
			((MonoBehaviour)this).StartCoroutine_Auto(girisYap(kullaniciAdi, sifre));
		}
	}

	public void OnGUI()
	{
		checked
		{
			GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 400), (float)(unchecked(Screen.height / 2) - 300), 800f, 600f), string.Empty, menubg);
			GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 180), 20f, 360f, 203f), string.Empty, logoHolder);
			GUI.Box(new Rect((float)(unchecked(Screen.width / 2) - 222), (float)(unchecked(Screen.height / 2) - 60), 445f, 238f), string.Empty, kullaniciGirBg);
			kullaniciAdi = GUI.TextField(new Rect((float)(unchecked(Screen.width / 2) - 50), (float)unchecked(Screen.height / 2), 225f, 39f), kullaniciAdi, inputStil);
			if (GUI.Button(new Rect((float)(unchecked(Screen.width / 2) - 51), (float)(unchecked(Screen.height / 2) + 100), 102f, 37f), string.Empty, gonderBut))
			{
				gonderi = true;
				((MonoBehaviour)this).StartCoroutine_Auto(girisYap(kullaniciAdi, sifre));
			}
			if (gonderi)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 50), (float)(unchecked(Screen.height / 2) + 140), 400f, 100f), "Kontrol Ediliyor...", hataStil);
			}
			if (!durum)
			{
				gonderi = false;
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 50), (float)(unchecked(Screen.height / 2) + 140), 400f, 100f), "Kullanc ad veya ifre yanl.", hataStil);
			}
		}
	}

	public void Main()
	{
	}
}
