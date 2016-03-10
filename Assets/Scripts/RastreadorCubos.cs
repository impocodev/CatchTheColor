using UnityEngine;
using System.Collections;

public class RastreadorCubos : MonoBehaviour {




//	static public int full = 5;
//	static public int Blanco = 0;
//	static public int Rojo = 0;
//	static public int Amarillo = 0;
//	static public int Azul = 0;
//	static public int Fucsia = 0;
//	static public int Verde = 0;


//	static public bool enableBlanco = true;
	static public bool enableRojo = true;
	static public bool enableAmarillo = true;
	static public bool enableAzul = true;
	static public bool enableFucsia = true;
	static public bool enableVerde = true;

	// Update is called once per frame
	void Update () {
		
//		if (GameManager.Blanco == GameManager.full) {
//			enableblanco = false;
//		} else if (GameManager.Blanco < GameManager.full){
//			enableblanco = true;
//		}
	}
	void OnTriggerEnter (Collider col){
//		if (col.gameObject.tag == "Blanco") {
//			Blanco++;
//			print ("total blancos:" + Blanco);
//		}
		switch (col.gameObject.tag)
		{
			case "Amarillo":
				GameManager.Amarillo++;
			print ("total Amarillos:" + GameManager.Amarillo);
				break;
			case "Azul":
				GameManager.Azul++;
				print ("total Azules:" + GameManager.Azul);
				break;
			case "Rojo":
				GameManager.Rojo++;
				print ("total Rojos:" + GameManager.Rojo);
				break;
			case "Fucsia":
				GameManager.Fucsia++;
				print ("total Fucsias:" + GameManager.Fucsia);
				break;
			case "Blanco":
				GameManager.Blanco++;
				print ("total blancos:" + GameManager.Blanco);
				break;
			case "Verde":
				GameManager.Verde++;
				print ("total Verdes:" + GameManager.Verde);
				break;
		}
	}
}
