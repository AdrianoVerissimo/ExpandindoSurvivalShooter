using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour {
	GameObject player;
	PlayerStatus playerStatus;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); //pega objeto do jogador
		if (player != null)
		{
			playerStatus = player.GetComponentInChildren <PlayerStatus> (); //pega o script PlayerMovement do jogador
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//encostou no jogador
		if (other.CompareTag ("Player"))
		{
			//add power
			playerStatus.upgradeShootLevel();

			//destrói objeto
			Destroy(gameObject);
		}
	}
}
