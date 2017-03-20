using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour {

	public int shootingLevel = 1;
	public int maxShootingLevel = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void upgradeShootLevel()
	{
		shootingLevel++;
		if (shootingLevel > maxShootingLevel)
			shootingLevel = maxShootingLevel;
	}
}
