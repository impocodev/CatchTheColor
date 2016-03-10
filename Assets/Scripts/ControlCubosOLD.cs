using UnityEngine;
using System.Collections;
using System.Collections.Generic;
// todo el scrpit oriol. 
public class ControlCubosOLD : MonoBehaviour {
	// cubos de la escena
	public GameObject cuboAmarillo;
	public GameObject cuboRojo;
	public GameObject cuboAzul;
	public GameObject cuboFucsia;
	public GameObject cuboVerde;
	public GameObject cuboBlanco;
	//lista vacia 
	static public List<GameObject> listaCubos = new List<GameObject>();
	//añade los cubos a la lista si estan activos.
	void Update(){
		if (GameManager.enableAmarillo == true){
			listaCubos.Add (cuboAmarillo);
		}
		if (GameManager.enableRojo == true){
			listaCubos.Add (cuboRojo);
		}
		if (GameManager.enableAzul == true){
			listaCubos.Add (cuboAzul);
		}
		if (GameManager.enableFucsia == true){
			listaCubos.Add (cuboFucsia);
		}
		if (GameManager.enableVerde == true){
			listaCubos.Add (cuboVerde);
		}
		if (GameManager.enableBlanco == true){
			listaCubos.Add (cuboBlanco);
		}
	}
	//funcion que si es envocada activa todos los cubos(excepto el blanco).
	static public void cubosEnable(){
				GameManager.enableAmarillo = true;
				GameManager.enableRojo = true;
				GameManager.enableAzul = true;
				GameManager.enableFucsia = true;
				GameManager.enableVerde = true;
		
	}
	// funcion que desactiva el cubo de la ultima posicion.
	static public void cubosPosicion(){
		
		if (GameManager.posicion == GameManager.lastAmarillo){
			GameManager.enableAmarillo = false;
		}
		if (GameManager.posicion == GameManager.lastRojo){
			GameManager.enableRojo = false;
		}
		if (GameManager.posicion == GameManager.lastAzul){
			GameManager.enableAzul = false;
		}
		if (GameManager.posicion == GameManager.lastFucsia){
			GameManager.enableFucsia = false;
		}
		if (GameManager.posicion == GameManager.lastVerde){
			GameManager.enableVerde = false;
		}
		if (GameManager.posicion == GameManager.lastBlanco){
			GameManager.enableBlanco = false;
		}
	}
		

}
//		Instancias un nuevo objeto
//		nuevo = Instantiate(cubos[random...]...);
//		//Lo añades a la lista sin importar cuantos haya
//		listaCubos.Add (nuevo);
//		//Modificar elemento enésimo de la lista
//		listaCubos [n].setActive (false);
//		//Elementos de la lista
//		Debug.Log(listaCubo.Count);
//		//Elimina el elemento enésimo de la lista
//		listaCubos.Remove (n);
//		Debug.Log(listaCubo.Count);//Un número menos que antes.