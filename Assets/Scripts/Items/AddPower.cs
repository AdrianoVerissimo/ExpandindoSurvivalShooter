using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPower : MonoBehaviour {
	GameObject player;
	PlayerShooting playerShooting;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); //pega objeto do jogador
		if (player != null)
		{
			playerShooting = player.GetComponentInChildren <PlayerShooting> (); //pega o script PlayerShooting do jogador
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//encostou no jogador
		if (other.CompareTag ("Player"))
		{
			//add power
			playerShooting.upgradeShootingVelocity();

			//destrói objeto
			Destroy(gameObject);
		}
	}
}
