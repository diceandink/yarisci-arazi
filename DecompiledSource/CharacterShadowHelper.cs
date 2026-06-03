using UnityEngine;

[AddComponentMenu("")]
public class CharacterShadowHelper : MonoBehaviour
{
	private void OnPreCull()
	{
		CharacterShadow characterShadow = (CharacterShadow)(object)((Component)((Component)this).transform.parent).GetComponent(typeof(CharacterShadow));
		characterShadow.OnPreCull();
	}

	private void OnPostRender()
	{
		CharacterShadow characterShadow = (CharacterShadow)(object)((Component)((Component)this).transform.parent).GetComponent(typeof(CharacterShadow));
		characterShadow.OnPostRender();
	}
}
