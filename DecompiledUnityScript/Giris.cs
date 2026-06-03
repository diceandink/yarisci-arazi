using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class Giris : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class Start_002451 : GenericGenerator<WWW>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WWW>, IEnumerator
		{
			internal string _0024url_0024343;

			internal WWW _0024www_0024344;

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024url_0024343 = "http://www.trt.net.tr/trtcocuk/ruzgargulu/flashsayac.aspx?mesaj=YarisciOyun";
					_0024www_0024344 = new WWW(_0024url_0024343);
					return base.Yield(2, _0024www_0024344);
				case 2:
					base.Yield(1, (WWW)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		public override IEnumerator<WWW> GetEnumerator()
		{
			return (IEnumerator<WWW>)(object)new _0024();
		}
	}

	public IEnumerator Start()
	{
		yield return null;
	}

	public void Main()
	{
	}
}
