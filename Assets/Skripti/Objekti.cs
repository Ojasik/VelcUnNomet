using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglaa aina esoso kanvu
	public Canvas kanva;

	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementaMasina;
	public GameObject e46;
	public GameObject eskavators;
	public GameObject policija;
	public GameObject traktors1;
	public GameObject traktors5;
	public GameObject ugunszdeseji;

	//Uzglaba velkamo objektu sakotnejas atrasanas vietas koordinatas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementaKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 eskavatorsKoord;
	[HideInInspector]
	public Vector2 policijaKoord;
	[HideInInspector]
	public Vector2 traktors1Koord;
	[HideInInspector]
	public Vector2 traktors5Koord;
	[HideInInspector]
	public Vector2 ugunsKoord;


	//Uzglabas audio avotu, kura atskanot attelu skanas efektus
	public AudioSource skanasAvots;
	//Masivs, kas uzglaba visas iespejamas skanas
	public AudioClip[] skanaKoAtskanot;
	//Mainigais piefikse vai objeks nolikts istajavieta(true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//uzglabas pedejo objektu, kurs pakustinats
	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		b2Koord = b2.GetComponent<RectTransform> ().localPosition;
		cementaKoord = cementaMasina.GetComponent<RectTransform> ().localPosition;
		e46Koord = e46.GetComponent<RectTransform> ().localPosition;
		eskavatorsKoord = eskavators.GetComponent<RectTransform> ().localPosition;
		policijaKoord = policija.GetComponent<RectTransform> ().localPosition;
		traktors1Koord = traktors1.GetComponent<RectTransform> ().localPosition;
		traktors5Koord = traktors5.GetComponent<RectTransform> ().localPosition;
		ugunsKoord = ugunszdeseji.GetComponent<RectTransform> ().localPosition;
	}
	

}
