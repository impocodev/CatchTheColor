using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Cubos : MonoBehaviour
{

    public GameObject[] cubos = new GameObject[6];
    public float minTiempoEntreCubos = 1.0f, maxTiempoEntreCubos = 1.5f;
    public float minX = -24.0f, maxX = 24.0f;
    public float minZ = -11.0f, maxZ = 11.0f;
    public float y = 1.0f;
	float tiempo = 60.0f;

    private bool lanzadorCubos = true;
	private Rigidbody rigidbody;

    // Use this for initialization
    void Start()
    {
		gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
        StartCoroutine(CubosEnJuego());
		StartCoroutine(CuentaAtras());
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene ("CatchTheColor");
		}
		if (GameManager.Blanco == GameManager.full) {
			GameManager.enableBlanco = false;
		} else if (GameManager.Blanco < GameManager.full){
			GameManager.enableBlanco = true;
		}
	}
	IEnumerator CuentaAtras()
	{
		while (tiempo > 0)
		{
			tiempo--;
			GameManager.tiempoTranscurrido = tiempo;
			yield return new WaitForSeconds(1);
		}
	}
    // Update is called once per frame

    IEnumerator CubosEnJuego()
	{
		// Initial delay
		yield return new WaitForSeconds (2.0f);

<<<<<<< HEAD
		while (lanzadorCubos) {
<<<<<<< HEAD
<<<<<<< HEAD
			if (gameObject.transform.position.x < 0 && gameObject.transform.position.z > 0) {
				//N0 = 1
				GameManager.posicion = 1;
			} else if (gameObject.transform.position.x > 0 && gameObject.transform.position.z > 0) {
				//NE = 2
				GameManager.posicion = 2;
			} else if (gameObject.transform.position.x < 0 && gameObject.transform.position.z < 0) {
				//SO = 3
				GameManager.posicion = 3;
			}  else if (gameObject.transform.position.x > 0 && gameObject.transform.position.z < 0) {
				//SE = 4
				GameManager.posicion = 4;
=======
            if (RastreadorCubos.enableblanco) 
			{
				GameObject cubo = (GameObject)Instantiate (cubos [Random.Range (0, cubos.Length)]);
				cubo.transform.position = new Vector3 (Random.Range (minX, maxX), y, Random.Range (minZ, maxZ));
				cubo.transform.rotation = Random.rotation;
				rigidbody = cubo.GetComponent<Rigidbody> ();
				GameManager.cubosLanzados++;
			} 
			else 
			{
				GameObject cubo = (GameObject)Instantiate (cubos [Random.Range (0, 5)]);
				cubo.transform.position = new Vector3 (Random.Range (minX, maxX), y, Random.Range (minZ, maxZ));
				cubo.transform.rotation = Random.rotation;
				rigidbody = cubo.GetComponent<Rigidbody> ();
				GameManager.cubosLanzados++;
>>>>>>> origin/Rodrigo
			}
			print ("posicion lanzador:" + GameManager.posicion);
			ControlCubos.cubosPosicion ();
=======
>>>>>>> parent of 948a920... separando scripts
=======
>>>>>>> parent of 948a920... separando scripts
			RaycastHit hit;
			Ray rayo = new Ray (transform.position, Vector3.down);
			if (Physics.SphereCast (rayo,1.0f, out hit, 30.0f)) {
				if (hit.collider.tag == "Respawn") {
					if (GameManager.enableBlanco) {
						print ("respawn!!!!!");
						GameObject cubo = (GameObject)Instantiate (cubos [Random.Range (0, cubos.Length)]);
						cubo.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
						cubo.transform.rotation = Random.rotation;
						rigidbody = cubo.GetComponent<Rigidbody> ();
						GameManager.cubosLanzados++;
						gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
					} else {
						print ("respawn!!!!!");
						GameObject cubo = (GameObject)Instantiate (cubos [Random.Range (0, 5)]);
						cubo.transform.position = new Vector3 (transform.position.x, y, transform.position.z);
						cubo.transform.rotation = Random.rotation;
						rigidbody = cubo.GetComponent<Rigidbody> ();
						GameManager.cubosLanzados++;
						gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
					}
				} else {
					gameObject.transform.position = new Vector3 (Random.Range (minX, maxX), 25, Random.Range (minZ, maxZ));
					print ("not respawn.");
				}
			}
			yield return new WaitForSeconds (Random.Range (minTiempoEntreCubos, maxTiempoEntreCubos));
		}
	}
}
