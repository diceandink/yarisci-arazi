using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class kilit : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class baslat_002438 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal kilit _0024self_291;

			public _0024(kilit self_)
			{
				_0024self_291 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					return base.Yield(2, new WaitForSeconds(1f));
				case 2:
					((MonoBehaviour)_0024self_291.ekranTus).StartCoroutine_Auto(_0024self_291.ekranTus.oyunBaslat());
					_0024self_291.soruTusKilit = false;
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal kilit _0024self_292;

		public baslat_002438(kilit self_)
		{
			_0024self_292 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_292);
		}
	}

	public bool soruTusKilit;

	public ekranGoruntuleri ekranTus;

	public void Start()
	{
		soruTusKilit = false;
		ekranTus = (ekranGoruntuleri)(object)UnityEngine.Object.FindObjectOfType(typeof(ekranGoruntuleri));
	}

	public IEnumerator baslat()
	{
		return new baslat_002438(this).GetEnumerator();
	}

	public void Main()
	{
	}
}
