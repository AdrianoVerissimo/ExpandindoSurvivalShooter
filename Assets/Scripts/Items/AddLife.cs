using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLife : MonoBehaviour {

	public PlayerHealth playerHealth;
	public int health = 20;

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			//add energia
			playerHealth.addHealth(health);

			//destrói objeto
			Destroy(gameObject);
		}
	}
}
