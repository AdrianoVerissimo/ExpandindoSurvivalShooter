using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutItem : MonoBehaviour {

	public float timeBeforeFade = 2f; //tempo antes de fazer o fade out
	public bool destroyAfterFade = true; //se destruirá o objeto após o fade out

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();

		Invoke ("ActivateFade", timeBeforeFade); //chama método de fade após um tempo
	}

	//ativa a animação de fade out
	void ActivateFade()
	{
		anim.SetTrigger ("ItemFadeOut");
	}

	//destrói o objeto. Chamado automaticamente ao fim da animação de fade out no Animator deste objeto.
	public void DestroyObject ()
	{
		if (destroyAfterFade) //marcou para destruir
			Destroy (gameObject);
	}
}
