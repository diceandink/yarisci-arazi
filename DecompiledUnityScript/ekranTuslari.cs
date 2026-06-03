using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ekranTuslari : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class sahneYukle_002446 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ekranTuslari _0024self_307;

			public _0024(ekranTuslari self_)
			{
				_0024self_307 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					return base.Yield(2, new WaitForSeconds(2f));
				case 2:
					_0024self_307.loaderEkran = true;
					return base.Yield(3, new WaitForSeconds(0.5f));
				case 3:
					while (!Application.CanStreamedLevelBeLoaded("Oyun_01"))
					{
					}
					Application.LoadLevel("Oyun_01");
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal ekranTuslari _0024self_308;

		public sahneYukle_002446(ekranTuslari self_)
		{
			_0024self_308 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_308);
		}
	}

	public static int aracSecim = 1;

	public GUIStyle loader;

	public bool loaderEkran;

	public GameObject araclar;

	public float counter;

	public bool donusAcik;

	public string donusYonu;

	public GameObject akrep;

	public GameObject panter;

	public GameObject boga;

	public GameObject orumcek;

	public bool donusKilitle;

	public AudioSource secimSes;

	public AudioSource girisSes;

	public GUIStyle sagTus;

	public GUIStyle solTus;

	public GUIStyle yazim;

	public ekranTuslari()
	{
		loaderEkran = false;
		counter = 0f;
		donusAcik = false;
		donusYonu = string.Empty;
		donusKilitle = false;
	}

	public IEnumerator sahneYukle()
	{
		return new sahneYukle_002446(this).GetEnumerator();
	}

	public void Start()
	{
		Time.timeScale = 1f;
		aracSecim = 1;
		araclar = GameObject.FindWithTag("araclardonus");
		akrep = GameObject.Find("akrep");
		panter = GameObject.Find("panter");
		boga = GameObject.Find("boga");
		orumcek = GameObject.Find("orumcek");
		donusKilitle = false;
		counter = 0f;
		donusAcik = false;
		AnimasyonDurdur();
	}

	public void sagCevir()
	{
		if (counter < 90f)
		{
			counter += 2f;
			araclar.transform.Rotate(0f, 2f, 0f);
		}
		else
		{
			donusKilitle = true;
			donusAcik = false;
			counter = 0f;
			donusKilitle = false;
		}
	}

	public void solCevir()
	{
		if (counter < 90f)
		{
			counter += 2f;
			araclar.transform.Rotate(0f, -2f, 0f);
		}
		else
		{
			donusKilitle = true;
			donusAcik = false;
			counter = 0f;
			donusKilitle = false;
		}
	}

	public void FixedUpdate()
	{
		checked
		{
			if (donusAcik)
			{
				if (donusYonu == "sag")
				{
					sagCevir();
				}
				else if (donusYonu == "sol")
				{
					solCevir();
				}
			}
		}
	}

	public void AnimasyonDurdur()
	{
		akrep.animation.Stop();
		boga.animation.Stop();
		orumcek.animation.Stop();
		panter.animation.Stop();
	}

	public void Update()
	{
		checked
		{
			if (!donusAcik && !donusKilitle)
			{
				if (Input.GetButtonUp("sag"))
				{
					secimSes.Play();
					if (aracSecim < 4)
					{
						aracSecim++;
					}
					else
					{
						aracSecim = 1;
					}
					donusYonu = "sag";
					donusAcik = true;
					AnimasyonDurdur();
				}
				else if (Input.GetButtonUp("sol"))
				{
					secimSes.Play();
					if (aracSecim > 1)
					{
						aracSecim--;
					}
					else
					{
						aracSecim = 4;
					}
					donusYonu = "sol";
					donusAcik = true;
					AnimasyonDurdur();
				}
				else if (Input.GetButtonUp("secim"))
				{
					girisSes.Play();
					((MonoBehaviour)this).StartCoroutine_Auto(sahneYukle());
				}
			}
		}
		switch (aracSecim)
		{
		case 1:
			panter.transform.Rotate(0f, 0f, 1f * 60f * Time.deltaTime);
			break;
		case 2:
			boga.transform.Rotate(0f, 0f, 1f * 60f * Time.deltaTime);
			break;
		case 3:
			orumcek.transform.Rotate(0f, 0f, 1f * 60f * Time.deltaTime);
			break;
		case 4:
			akrep.transform.Rotate(0f, 0f, 1f * 60f * Time.deltaTime);
			break;
		}
	}

	public void OnGUI()
	{
		checked
		{
			if (loaderEkran)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 640), (float)(unchecked(Screen.height / 2) - 400), 1280f, 800f), string.Empty, loader);
				return;
			}
			if (GUI.Button(new Rect(150f, 450f, 40f, 42f), string.Empty, solTus))
			{
				if (donusAcik)
				{
					solCevir();
				}
				else if (!donusKilitle)
				{
					secimSes.Play();
					if (aracSecim > 1)
					{
						aracSecim--;
					}
					else
					{
						aracSecim = 4;
					}
					donusYonu = "sol";
					donusAcik = true;
					AnimasyonDurdur();
				}
			}
			if (GUI.Button(new Rect(600f, 450f, 40f, 42f), string.Empty, sagTus))
			{
				if (donusAcik)
				{
					sagCevir();
				}
				else if (!donusKilitle)
				{
					secimSes.Play();
					if (aracSecim < 4)
					{
						aracSecim++;
					}
					else
					{
						aracSecim = 1;
					}
					donusYonu = "sag";
					donusAcik = true;
					AnimasyonDurdur();
				}
			}
			GUI.Label(new Rect(230f, 540f, 600f, 200f), "Seçim yapmak için 'Giriş(Enter)' tuşuna basınız.", yazim);
			GUI.Label(new Rect((float)(Screen.width - 250), (float)(Screen.height - 40), 250f, 30f), "github.com/diceandink - 2026", yazim);
		}
	}

	public void Main()
	{
	}
}
