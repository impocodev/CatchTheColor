using UnityEngine;
using System.Collections;

public class ModoContrareloj : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();
    public GameObject suelo = new GameObject();
	public AudioClip puntoAudio;
	TrailRenderer trazo;
	AudioSource audio;


	void Start(){
		trazo = GetComponent<TrailRenderer> ();
		audio = GetComponent<AudioSource> ();
	}
    public void Update()
    {
        if (GameManager.tiempoTranscurrido == 0)
            Application.LoadLevel("Final");
    }
    void OnCollisionEnter(Collision col)
    {
        Color colorEsferaActual = esfera.GetComponent<Renderer>().material.color;

        if (colorEsferaActual == Color.white)
        {
            switch (col.gameObject.tag)
            {
<<<<<<< HEAD
                case "Amarillo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Amarillo";
                    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
<<<<<<< HEAD
					GameManager.Amarillo--;
=======
>>>>>>> origin/Rodrigo
=======
			case "Amarillo":
				Destroy (col.gameObject);
				Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				gameObject.tag = "Amarillo";
				gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
				GameManager.Amarillo--;
				scriptShake.shaking = true;
				trazo.material.color = Color.yellow;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén

>>>>>>> Ruben
                    break;
                case "Azul":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Azul";
<<<<<<< HEAD
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
<<<<<<< HEAD
					GameManager.Azul--;
=======
>>>>>>> origin/Rodrigo
=======
                    gameObject.GetComponent<Renderer>().material.color = Color.cyan;
					GameManager.Azul--;
					trazo.material.color = Color.cyan;
				scriptShake.shaking = true;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                    break;
                case "Rojo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Rojo";
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
<<<<<<< HEAD
					GameManager.Rojo--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
				scriptShake.shaking = true;
				trazo.material.color = Color.red;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                    break;
                case "Fucsia":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Fucsia";
                    gameObject.GetComponent<Renderer>().material.color = Color.magenta;
<<<<<<< HEAD
					GameManager.Fucsia--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
				scriptShake.shaking = true;
				trazo.material.color = Color.magenta;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                    break;
                case "Blanco":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
                    gameObject.tag = "Blanco";
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
					GameManager.Blanco--;
<<<<<<< HEAD
=======
                    RastreadorCubos.inBlanco--;
                    gameObject.tag = "Blanco";
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
>>>>>>> origin/Rodrigo
=======
				scriptShake.shaking = true;
				trazo.material.color = Color.white;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                    break;

                case "Verde":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Verde";
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
<<<<<<< HEAD
					GameManager.Verde--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
				scriptShake.shaking = true;
				trazo.material.color = Color.green;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                    break;
            }
        }
        else {
            if (col.gameObject.tag == gameObject.tag)
            {
                if (col.gameObject.tag == "Amarillo" && gameObject.tag == "Amarillo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Amarillo--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
					scriptShake.shaking = true;
					trazo.material.color = Color.yellow;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                }
                if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Azul--;
					scriptShake.shaking = true;
					trazo.material.color = Color.cyan;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
					
=======
>>>>>>> origin/Rodrigo
                }
                if (col.gameObject.tag == "Verde" && gameObject.tag == "Verde")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Verde--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
					scriptShake.shaking = true;
					trazo.material.color = Color.green;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                }
                if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Fucsia--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
					scriptShake.shaking = true;
					trazo.material.color = Color.magenta;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                }
                if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Rojo--;
<<<<<<< HEAD
=======
>>>>>>> origin/Rodrigo
=======
					scriptShake.shaking = true;
					trazo.material.color = Color.red;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
                }
            }
            if (col.gameObject.tag == "Blanco")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                GameManager.cubosDestruidos++;
<<<<<<< HEAD
				GameManager.Blanco--;
<<<<<<< HEAD
=======
                RastreadorCubos.inBlanco--;
>>>>>>> origin/Rodrigo
=======
				scriptShake.shaking = true;
				trazo.material.color = Color.white;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
>>>>>>> Ruben
            }
        }
    }
}
