using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class CarpismaSes : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class OnTriggerEnter_002449 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal CarpismaSes _0024self_339;

			public _0024(CarpismaSes self_)
			{
				_0024self_339 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					if (!_0024self_339.sesiKapat)
					{
						_0024self_339.sesiKapat = true;
						((Component)_0024self_339).audio.Play();
						return base.Yield(2, new WaitForSeconds(2f));
					}
					goto IL_0063;
				case 2:
					_0024self_339.sesiKapat = false;
					goto IL_0063;
				case 1:
					break;
					IL_0063:
					base.Yield(1, (WaitForSeconds)null);
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal CarpismaSes _0024self_340;

		public OnTriggerEnter_002449(CarpismaSes self_)
		{
			_0024self_340 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_340);
		}
	}

	public bool sesiKapat;

	public CarpismaSes()
	{
		sesiKapat = false;
	}

	public IEnumerator OnTriggerEnter(Collider other)
	{
		return new OnTriggerEnter_002449(this).GetEnumerator();
	}

	public void Main()
	{
	}
}
