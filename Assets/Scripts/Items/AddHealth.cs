using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHealth : MonoBehaviour {

	public int health = 20;

	GameObject player;
	PlayerHealth playerHealth;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player"); //pega objeto do jogador
		if (player != null)
		{
			playerHealth = player.GetComponentInChildren <PlayerHealth> (); //pega o script PlayerHealth do jogador
		}
	}

	void OnTriggerEnter (Collider other)
	{
		//encostou no jogador
		if (other.CompareTag ("Player"))
		{
			//add energia
			playerHealth.addHealth(health);

			//destrói objeto
			Destroy(gameObject);
		}
	}
}
