﻿using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth; //referência para energia do jogador
    public GameObject[] enemies; //referência para o inimigo que queremos dar spawn
    public float spawnTime = 3f; //tempo para dar spawn em um novo inimigo
	public float spawnDecreaseTime = 0.2f;
	public float timeBeforeDecreaseSpawn = 60f;
	public float minSpawnTime = 1f;
    public Transform[] spawnPoints; //guarda os pontos de spawns


    void Start ()
    {
		CreateInvokes ();
    }

	//cria o inimigo em um determinado lugar da fase
    void Spawn ()
    {
		//se o jogador morreu, não dar mais spawns
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length); //pega aleatoriamente um dos pontos de spawn passados como parâmetro

		int posArrayEnemies = 0;

		if (enemies.Length > 0)
			posArrayEnemies = Random.Range (0, enemies.Length);

		//instancia o inimigo
		Instantiate (enemies[posArrayEnemies], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

	void DecreaseSpawnTime()
	{
		spawnTime -= spawnDecreaseTime;
		if (spawnTime < minSpawnTime)
			spawnTime = minSpawnTime;

		CancelInvoke ();
		CreateInvokes ();
	}

	void CreateInvokes()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime); //chama repetitivamente o método Spawn
		InvokeRepeating("DecreaseSpawnTime", timeBeforeDecreaseSpawn, timeBeforeDecreaseSpawn);
	}
}
