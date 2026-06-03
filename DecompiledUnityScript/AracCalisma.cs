using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class AracCalisma : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class Start_002432 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal AracCalisma _0024self_337;

			public _0024(AracCalisma self_)
			{
				_0024self_337 = self_;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					_0024self_337.kontak.Play();
					return base.Yield(2, new WaitForSeconds(3f));
				case 2:
					_0024self_337.kontak.Stop();
					_0024self_337.muzik.Play();
					_0024self_337.motor.Play();
					base.Yield(1, (WaitForSeconds)null);
					break;
				case 1:
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal AracCalisma _0024self_338;

		public Start_002432(AracCalisma self_)
		{
			_0024self_338 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024self_338);
		}
	}

	public AudioSource kontak;

	public AudioSource motor;

	public AudioSource muzik;

	public IEnumerator Start()
	{
		return new Start_002432(this).GetEnumerator();
	}

	public void sesAyarla(float hiz)
	{
		motor.pitch = hiz / 15f + 0.2f;
		if (motor.pitch > 3f)
		{
			motor.pitch = 3f;
		}
	}

	public void Main()
	{
	}
}
