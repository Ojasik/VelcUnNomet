using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jaimporte, lai lietotu visus I interfeisus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//Velkamajam objektam piestiprinata komponente
	private CanvasGroup kanvasGrupa;
	//Prieks parvietojama objekta atrasanas vietas izglabasanas
	private RectTransform velkObjRectTransf;
	//Norade uz objektu skriptu
	public Objekti objektuSkripts;


	// Use this for initialization
	void Start () {
		//Pieklust objekta piestiprinajai CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Pieklust objekta RectTransform komponentei
		velkObjRectTransf = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	public void OnPointerDown (PointerEventData notikums) {
		Debug.Log ("Uzklikšināts uz velkama objekta!");
	}

	public void OnBeginDrag (PointerEventData notikums) {
		Debug.Log ("Uzsakta vilksana!");
		//Velkot objektu paliek caruspidigs
		kanvasGrupa.alpha = 0.6f;
		//Lai objektam velkot iet cauri raycast stari
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData notikums) {
		Debug.Log ("Notiek vilkšana!");
		//Maina objekta x,y koordinatas
		velkObjRectTransf.anchoredPosition+= notikums.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OrEndDrag (PointerEventData notikums) {
		Debug.Log ("Beigta objekta vilkšana!");


	}
}
