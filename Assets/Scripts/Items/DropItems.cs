using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItems : MonoBehaviour {

	public GameObject[] items;
	public Transform dropPoint; //onde o item aparecerá
	public float dropPercent = 50.0f; //percentual para o item aparecer

	void Start()
	{
		if (items.Length == 0) {
			Debug.Log ("Erro em DropItems.cs: é necessário inserir 'GameObjects' na propriedade 'items'");
		}
	}

	//método para dropar um ítem aleatório da lista de ítens
	public void drop()
	{
		if (!canDrop())
			return;
		
		GameObject item = items [Random.Range (0, items.Length)]; //pega um ítem aleatório
		if (item == null)
			return;

		Instantiate (item, dropPoint.position, dropPoint.rotation); //instancia o item
	}

	bool canDrop()
	{
		float random = Random.Range(0.0f, 100.0f);
		if (random <= dropPercent)
			return true;

		return false;
	}
}
