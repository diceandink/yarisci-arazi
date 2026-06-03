using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using UnityEngine;

[Serializable]
public class SkorGonder : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class skorGonder_002452 : GenericGenerator<WWW>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WWW>, IEnumerator
		{
			internal string _0024yollanacakSkor_0024345;

			internal string _0024url_0024346;

			internal WWW _0024www_0024347;

			internal object _0024skor348;

			internal object _0024kullanici349;

			internal object _0024sifre350;

			internal SkorGonder _0024self_351;

			public _0024(object skor, object kullanici, object sifre, SkorGonder self_)
			{
				_0024skor348 = skor;
				_0024kullanici349 = kullanici;
				_0024sifre350 = sifre;
				_0024self_351 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024yollanacakSkor_0024345 = (string)RuntimeServices.Coerce(RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.Invoke(_0024skor348, "Substring", new object[2] { 0, 2 }), (object)"@"), RuntimeServices.Invoke(_0024skor348, "Substring", new object[2] { 3, 2 })), (object)"@"), RuntimeServices.Invoke(_0024skor348, "Substring", new object[2] { 6, 2 })), typeof(string));
					_0024url_0024346 = (string)RuntimeServices.Coerce(RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", RuntimeServices.InvokeBinaryOperator("op_Addition", (object)("http://www.trt.net.tr/trtcocuk/yarisci/skorkaydet.aspx?skor=" + _0024yollanacakSkor_0024345 + "&kullanici="), _0024kullanici349), (object)"&sifre="), _0024sifre350), typeof(string));
					_0024www_0024347 = new WWW(_0024url_0024346);
					return base.Yield(2, _0024www_0024347);
				case 2:
					_0024self_351.cevap = _0024www_0024347.data;
					base.Yield(1, (WWW)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal object _0024skor352;

		internal object _0024kullanici353;

		internal object _0024sifre354;

		internal SkorGonder _0024self_355;

		public skorGonder_002452(object skor, object kullanici, object sifre, SkorGonder self_)
		{
			_0024skor352 = skor;
			_0024kullanici353 = kullanici;
			_0024sifre354 = sifre;
			_0024self_355 = self_;
		}

		public override IEnumerator<WWW> GetEnumerator()
		{
			return (IEnumerator<WWW>)(object)new _0024(_0024skor352, _0024kullanici353, _0024sifre354, _0024self_355);
		}
	}

	public string cevap;

	public void Start()
	{
		((MonoBehaviour)this).StartCoroutine_Auto(skorGonder("011248", "omer", "omer"));
	}

	public IEnumerator skorGonder(object skor, object kullanici, object sifre)
	{
		cevap = "Skor kaydedildi!";
		yield return null;
	}

	public void OnGUI()
	{
		GUI.Label(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2), (float)Screen.width, (float)Screen.height), cevap, new GUIStyle(string.Empty));
	}

	public void Main()
	{
	}
}
