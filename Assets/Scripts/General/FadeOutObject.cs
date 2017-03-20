using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutObject : MonoBehaviour {

	public bool destroyOnFinish = true;
	public float fadeTime = 2.0f;

	Color color;
	float currentAlpha;
	float timer = 0f;


	//ver esta documentação:
	//https://docs.unity3d.com/ScriptReference/Mathf.SmoothDamp.html

	// Use this for initialization
	void Start () {
		color = GetComponent<MeshRenderer> ().material.color;
		color.a = 0.0f;
		currentAlpha = GetComponent<MeshRenderer> ().material.color.a;

		Invoke ("DestroyObject", fadeTime);
	}

	// Update is called once per frame
	void Update () {

		/*currentAlpha = Mathf.SmoothStep (0f, 10f, 20.0f);
		Debug.Log (currentAlpha);

		GetComponent<MeshRenderer> ().material.color = new Color(
			GetComponent<MeshRenderer> ().material.color.r,
			GetComponent<MeshRenderer> ().material.color.g,
			GetComponent<MeshRenderer> ().material.color.b,
			currentAlpha);*/

		/*timer = Time.deltaTime / fadeTime;
		GetComponent<MeshRenderer> ().material.color = Color.Lerp (
			GetComponent<MeshRenderer> ().material.color,
			color,
			timer);
		*/
		/*if (Mathf.Clamp(GetComponent<MeshRenderer> ().material.color.a, 0.0f, 1.0f) <= 0.0f)
			Debug.Log ("----------------------------------------oi----------------------------------------");
		Debug.Log ((float)GetComponent<MeshRenderer> ().material.color.a);*/

		/*float newAlpha = Mathf.Lerp (
			currentAlpha,
			0.0f,
			fadeVelocity * Time.deltaTime
		);

		currentAlpha = newAlpha;
		GetComponent<MeshRenderer> ().material.color = new Color(
			GetComponent<MeshRenderer> ().material.color.r,
			GetComponent<MeshRenderer> ().material.color.g,
			GetComponent<MeshRenderer> ().material.color.b,
			newAlpha);
		Debug.Log (newAlpha);
		if (newAlpha <= 0.0f && destroyOnFinish)
		{
			Destroy (gameObject);
		}*/
	}

	public void DestroyObject()
	{
		Destroy (gameObject);
	}
}
