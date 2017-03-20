using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItems : MonoBehaviour {

	public GameObject[] items;
	public Transform dropPoint; //onde o item aparecerá
	public float dropPercent = 50.0f; //percentual para o item aparecer

	int itemPosition = 0;

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

		//pega um item aleatório da lista
		itemPosition = Random.Range (0, items.Length);
		GameObject item = items [itemPosition]; //pega um ítem aleatório
		if (item == null) //se não encontrou item, retornar
			return;

		Instantiate (item, dropPoint.position, dropPoint.rotation); //instancia o item
	}

	//verifica se irá dropar um item
	bool canDrop()
	{
		float random = Random.Range(0.0f, 100.0f); //gera um número aleatório
		if (random <= dropPercent) //se o número está entre o percentual estabelecido, vai dropar
			return true;

		return false; //não vai dropar
	}
}
