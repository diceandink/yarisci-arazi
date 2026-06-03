using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using UnityEngine;

[Serializable]
public class SlowMotionRampa : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class OnTriggerEnter_002445 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal PlayerCar_Script _0024playercar_0024283;

			internal MotionBlur _0024blur_0024284;

			internal Collider _0024other285;

			public _0024(Collider other)
			{
				_0024other285 = other;
			}

			public override bool MoveNext()
			{
				switch (base._state)
				{
				default:
					if (((Component)_0024other285).CompareTag("Player"))
					{
						_0024playercar_0024283 = (PlayerCar_Script)(object)UnityEngine.Object.FindObjectOfType(typeof(PlayerCar_Script));
						_0024blur_0024284 = (MotionBlur)UnityEngine.Object.FindObjectOfType(typeof(MotionBlur));
						_0024playercar_0024283.OyunDondur(0.1f);
						_0024blur_0024284.blurAmount = 0.8f;
						return base.Yield(2, new WaitForSeconds(0.3f));
					}
					goto IL_00af;
				case 2:
					_0024playercar_0024283.OyunDevam();
					_0024blur_0024284.blurAmount = 0f;
					goto IL_00af;
				case 1:
					break;
					IL_00af:
					base.Yield(1, (WaitForSeconds)null);
					break;
				}
				bool result = default(bool);
				return result;
			}
		}

		internal Collider _0024other286;

		public OnTriggerEnter_002445(Collider other)
		{
			_0024other286 = other;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return (IEnumerator<WaitForSeconds>)(object)new _0024(_0024other286);
		}
	}

	public IEnumerator OnTriggerEnter(Collider other)
	{
		return new OnTriggerEnter_002445(other).GetEnumerator();
	}

	public void Main()
	{
	}
}
