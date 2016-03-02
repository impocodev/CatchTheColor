using UnityEngine;
using System.Collections;

public class RastreadorCubos : MonoBehaviour {




	static public int full = 3;
	static public int inBlanco = 0;

	static public bool enableblanco = true;

	// Update is called once per frame
	void Update () {
		if (inBlanco == full) {
			enableblanco = false;
		} else if (inBlanco < full){
			enableblanco = true;
		}
	}
	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "Blanco") {
			inBlanco++;
			print ("total blancos:" + inBlanco);
		}
	}
}
