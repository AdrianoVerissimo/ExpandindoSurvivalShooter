using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutItem : MonoBehaviour {

	public float timeBeforeFade = 2f;
	public bool destroyAfterFade = true;

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

		Invoke ("ActivateFade", timeBeforeFade);
	}

	void ActivateFade()
	{
		anim.SetTrigger ("ItemFadeOut");
	}

	public void DestroyObject ()
	{
		if (destroyAfterFade)
			Destroy (gameObject);
	}
}
