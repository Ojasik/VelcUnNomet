using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importe, lai varetu ieladet ainas
using UnityEngine.SceneManagement;

public class UzGalvenoScript : MonoBehaviour {

	//Izdarot klikski uz pogas "uzAinu", tiks atverta aina "Pilseta"
	public void uzGalveno(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}

}
