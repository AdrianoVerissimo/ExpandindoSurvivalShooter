using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpeed : MonoBehaviour {

	public float value = 2.0f;

	GameObject player;
	PlayerMovement playerMovement;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); //pega objeto do jogador
		if (player != null)
		{
			playerMovement = player.GetComponentInChildren <PlayerMovement> (); //pega o script PlayerMovement do jogador
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//encostou no jogador
		if (other.CompareTag ("Player"))
		{
			//add velocidade
			playerMovement.addSpeed(value);

			//destrói objeto
			Destroy(gameObject);
		}
	}
}
