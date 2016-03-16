using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cubos : MonoBehaviour {
    
	public float minTiempoEntreCubos = 1.0f, maxTiempoEntreCubos = 1.5f;
    public float minX = -24.0f, maxX = 24.0f;
    public float minZ = -11.0f, maxZ = 11.0f;
    public float y = 1.0f;
	float tiempo = 60.0f;

    private bool lanzadorCubos = true;
	private Rigidbody rigidbody;

    // Use this for initialization
    void Start() {
		gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
        StartCoroutine(CubosEnJuego());
		StartCoroutine(CuentaAtras());
	}

	IEnumerator CuentaAtras() {
		while (tiempo > 0) {
			tiempo--;
			GameManager.tiempoTranscurrido = tiempo;
			yield return new WaitForSeconds(1);
		}
	}

    IEnumerator CubosEnJuego() {
		// Initial delay
		yield return new WaitForSeconds (2.0f);

		while (lanzadorCubos) {
			if (transform.position.x < 0 && transform.position.z > 0) {
				//N0 = 1
				GameManager.posicion = 1;
			} else if (transform.position.x > 0 && transform.position.z > 0) {
				//NE = 2
				GameManager.posicion = 2;
			} else if (transform.position.x < 0 && transform.position.z < 0) {
				//SO = 3
				GameManager.posicion = 3;
			} else if (transform.position.x > 0 && transform.position.z < 0) {
				//SE = 4
				GameManager.posicion = 4;
			}  
            print ("posicion lanzador:" + GameManager.posicion);
			ControlCubos.cubosPosicion ();
			RaycastHit hit;
			Ray rayo = new Ray (transform.position, Vector3.down);
			if (Physics.SphereCast (rayo,2.0f, out hit, 30.0f)) {
				if (hit.collider.tag == "Respawn") {
						GameObject cubo = (GameObject)Instantiate (ControlCubos.listaCubos [Random.Range (0, ControlCubos.listaCubos.Count)]);
						cubo.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
						cubo.transform.rotation = Random.rotation;
						rigidbody = cubo.GetComponent<Rigidbody> ();
						GameManager.cubosLanzados++;
						gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
						ControlCubos.listaCubos.Clear();//oriol. la lista de cubos se vacia.
						ControlCubos.cubosEnable ();//oriol. la funcion de cubosEbnable se ejecuta y vuelve a dejar todos en enable.
				} else {
					gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
					print ("not respawn.");
				}
			}
			yield return new WaitForSeconds (Random.Range (minTiempoEntreCubos, maxTiempoEntreCubos));
		}

	}


}
