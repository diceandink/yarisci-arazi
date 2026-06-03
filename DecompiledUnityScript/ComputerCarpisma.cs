using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class ComputerCarpisma : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class OnTriggerEnter_002450 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal ComputerCarpisma _0024self_341;

			public _0024(ComputerCarpisma self_)
			{
				_0024self_341 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					if (!_0024self_341.sesiKapat)
					{
						_0024self_341.sesiKapat = true;
						((Component)_0024self_341).audio.Play();
						return base.Yield(2, new WaitForSeconds(2f));
					}
					goto IL_0063;
				case 2:
					_0024self_341.sesiKapat = false;
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

		internal ComputerCarpisma _0024self_342;

		public OnTriggerEnter_002450(ComputerCarpisma self_)
		{
			_0024self_342 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_342);
		}
	}

	public bool sesiKapat;

	public ComputerCarpisma()
	{
		sesiKapat = false;
	}

	public IEnumerator OnTriggerEnter(Collider other)
	{
		return new OnTriggerEnter_002450(this).GetEnumerator();
	}

	public void Main()
	{
	}
}
