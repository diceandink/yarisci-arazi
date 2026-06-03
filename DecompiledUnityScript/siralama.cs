using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class siralama : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class Start_002448 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal siralama _0024self_293;

			public _0024(siralama self_)
			{
				_0024self_293 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					Time.timeScale = 1f;
					_0024self_293.oyuncu = (oyuncuSec)(object)UnityEngine.Object.FindObjectOfType(typeof(oyuncuSec));
					return base.Yield(2, new WaitForSeconds(1f));
				case 2:
					_0024self_293.yuklendi = true;
					((Component)_0024self_293).gameObject.SendMessage("siralamaYolla", (object)"dfsdf");
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal siralama _0024self_294;

		public Start_002448(siralama self_)
		{
			_0024self_294 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_294);
		}
	}

	public GUIStyle siralamaStyle;

	public GUIStyle skorSirala;

	public GUIStyle skorArkaplan;

	public oyuncuSec oyuncu;

	public bool yuklendi;

	public static UnityScript.Lang.Array oyuncular = new UnityScript.Lang.Array();

	public static UnityScript.Lang.Array skorlarT = new UnityScript.Lang.Array();

	public siralama()
	{
		yuklendi = false;
	}

	public IEnumerator Start()
	{
		return new Start_002448(this).GetEnumerator();
	}

	public void siralaDoldurOyuncu(string[] isimler)
	{
		for (int i = 0; i < ((isimler).Length); i = checked(i + 1))
		{
			oyuncular[i] = isimler[RuntimeServices.NormalizeArrayIndex((System.Array)isimler, i)];
			MonoBehaviour.print(oyuncular[i]);
		}
	}

	public void siralaDoldurZaman(string[] skorlar)
	{
		for (int i = 0; i < ((skorlar).Length); i = checked(i + 1))
		{
			skorlarT[i] = skorlar[RuntimeServices.NormalizeArrayIndex((System.Array)skorlar, i)];
			MonoBehaviour.print(skorlarT[i]);
		}
	}

	public void Update()
	{
		if (Input.GetKeyUp("k"))
		{
			Application.LoadLevel("oyuncuSecim");
		}
	}

	public void OnGUI()
	{
		checked
		{
			if (yuklendi)
			{
				GUI.Label(new Rect((float)(unchecked(Screen.width / 2) - 640), (float)(unchecked(Screen.height / 2) - 400), 1280f, 800f), string.Empty, skorArkaplan);
				if (oyuncuSec.turModu == 2)
				{
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 200), 731f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"1         ", oyuncular[1]),
						siralamaStyle
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 117), 731f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"2         ", oyuncular[0]),
						siralamaStyle
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 200), 212f, 80f),
						skorlarT[1],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 117), 212f, 80f),
						skorlarT[0],
						skorSirala
					}, typeof(MonoBehaviour));
				}
				else if (oyuncuSec.turModu == 1)
				{
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 200), 731f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"1   ", oyuncular[3]),
						siralamaStyle
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 117), 731f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"2   ", oyuncular[2]),
						siralamaStyle
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) - 35), 731f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"3   ", oyuncular[1]),
						siralamaStyle
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) - 385), (float)(unchecked(Screen.height / 2) + 47), 731f, 81f),
						RuntimeServices.InvokeBinaryOperator("op_Addition", (object)"4   ", oyuncular[0]),
						siralamaStyle
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 200), 212f, 80f),
						skorlarT[3],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 117), 212f, 80f),
						skorlarT[2],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) - 35), 212f, 80f),
						skorlarT[1],
						skorSirala
					}, typeof(MonoBehaviour));
					UnityRuntimeServices.Invoke((object)typeof(GUI), "Label", new object[3]
					{
						(object)new Rect((float)(unchecked(Screen.width / 2) + 170), (float)(unchecked(Screen.height / 2) + 47), 212f, 80f),
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
