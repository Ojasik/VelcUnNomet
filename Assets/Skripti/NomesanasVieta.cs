using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler {
	//Uzglabas velkama objekta un nomesanas lauka z rotaciju, ka ari rotacijas izmeru un pielaujamo starpibu
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;

	public Objekti objektuSkripts;

	//Nostradas, ja objektu censas nomest uz jebkuras nomesanas vietas
	public void OnDrop(PointerEventData notikums){
		//Parbauda vai tika vilkts un atlaists vispar kads objekts
		if (notikums.pointerDrag != null) {
			//Ja nomesanas vietas tags sakrit ar vilkta objekta tagu
			if (notikums.pointerDrag.tag.Equals (tag)) {
				//Iegust objekta rotaciju grados 
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				//Aprekina abu objektu z rotacijas starpibu
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				//Lidzigi ka ar Z rotaciju, japiefikse objektu izmeri pa x un y asim, ka ari starpiba
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);			
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				//Parbauda vai objektu rotacijas un izmeru starpiba ir pielaujamas robezas
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrejas nomesanas lauka
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [1]);
						break;
					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						break;
					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						break;
					default:
						Debug.Log ("Nedefinets tags!");

						break;
					}
				}
				//Ja objekts nomests nepareizaja lauka
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);

				//Objektu aizmet uz sakotnejo poziciju
				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKoord;
					break;
				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atroKoord;
					break;
				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
					break;
				default:
					Debug.Log ("Nedefinets tags!");

					break;
				}
			}
		}
	}
}
