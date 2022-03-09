using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour {
	public Objekti objektuSkripts;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if (objektuSkripts.pedejaisVilktais != null) {
			//Nospiezot Z taustinu rote preteji pulkstenraditaja virzienam
			if (Input.GetKey (KeyCode.Z)) {
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform> ().Rotate (0, 0, Time.deltaTime * 9f);
			}

			if (Input.GetKey (KeyCode.X)) {
				objektuSkripts.pedejaisVilktais.GetComponent<RectTransform> ().Rotate (0, 0, -Time.deltaTime * 9f);
			}

			if (Input.GetKey (KeyCode.UpArrow)) {
				if(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y >= 0.3f){
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y + 0.001f);
				}
			}

			if (Input.GetKey (KeyCode.DownArrow)) {
				if(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y <= 0.8f){
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y - 0.001f);
				}
			}

			if (Input.GetKey (KeyCode.LeftArrow)) {
				if(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x >= 0.3f){
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x - 0.001f, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y);
				}
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				if(objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x <= 0.8f){
					objektuSkripts.pedejaisVilktais.GetComponent<RectTransform> ().localScale = new Vector2 (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.x + 0.001f, objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().localScale.y);
				}
			}

			
		}
	}
}
