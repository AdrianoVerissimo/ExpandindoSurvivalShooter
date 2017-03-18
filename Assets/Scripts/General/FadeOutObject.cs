using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutObject : MonoBehaviour {

	public bool destroyOnFinish = true;
	public float fadeVelocity = 2.0f;

	Color color;
	float currentAlpha;

	// Use this for initialization
	void Start () {
		color = GetComponent<MeshRenderer> ().material.color;
		color.a = 0.0f;
		currentAlpha = GetComponent<MeshRenderer> ().material.color.a;
	}

	// Update is called once per frame
	void Update () {

		/*GetComponent<MeshRenderer> ().material.color = Color.Lerp (
			GetComponent<MeshRenderer> ().material.color,
			color,
			0.05f);

		float alpha = GetComponent<MeshRenderer> ().material.color.a;

		if (Mathf.Clamp01(alpha) <= 0f)
		{
			Destroy (gameObject);
		}*/

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
}
