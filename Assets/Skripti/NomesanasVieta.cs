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
					case "b2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						break;
					case "Cements":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [5]);
						break;
					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [6]);
						break;
					case "Eskavators":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [7]);
						break;
					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [8]);
						break;
					case "Traktors1":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [9]);
						break;
					case "Traktors5":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [10]);
						break;
					case "Ugunsdzeseji":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [11]);
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
				case "b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Koord;
					break;
				case "Cements":
					objektuSkripts.cementaMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.cementaKoord;
					break;
				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Koord;
					break;
				case "Eskavators":
					objektuSkripts.eskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.eskavatorsKoord;
					break;
				case "Policija":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition = objektuSkripts.policijaKoord;
					break;
				case "Traktors1":
					objektuSkripts.traktors1.GetComponent<RectTransform> ().localPosition = objektuSkripts.traktors1Koord;
					break;
				case "Traktors5":
					objektuSkripts.traktors5.GetComponent<RectTransform> ().localPosition = objektuSkripts.traktors5Koord;
					break;
				case "Ugunsdzeseji":
					objektuSkripts.ugunszdeseji.GetComponent<RectTransform> ().localPosition = objektuSkripts.ugunsKoord;
					break;

				default:
					Debug.Log ("Nedefinets tags!");

					break;
				}
			}
		}
	}
}
