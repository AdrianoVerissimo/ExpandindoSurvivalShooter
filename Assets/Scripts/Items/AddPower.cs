using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour {
	GameObject player;
	PlayerStatus playerStatus;
	PlayerShooting playerShooting;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); //pega objeto do jogador
		if (player != null)
		{
			playerStatus = player.GetComponentInChildren <PlayerStatus> (); //pega o script PlayerMovement do jogador
			playerShooting = player.GetComponentInChildren <PlayerShooting> ();
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//encostou no jogador
		if (other.CompareTag ("Player"))
		{
			//add power
			//playerStatus.upgradeShootLevel();
			playerShooting.upgradeShootingVelocity();

			//destrói objeto
			Destroy(gameObject);
		}
	}
}
