using UnityEngine;
using System.Collections;

public class ModoSupervivencia : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();
	public AudioClip puntoAudio;
	TrailRenderer trazo;
	AudioSource audio;

	void Start(){
		trazo = GetComponent<TrailRenderer> ();
		audio = GetComponent<AudioSource> ();
	}

    void OnCollisionEnter(Collision col)
    {
        Color colorEsferaActual = esfera.GetComponent<Renderer>().material.color;
        if (colorEsferaActual == Color.white)
        {
            switch (col.gameObject.tag)
            {
<<<<<<< HEAD:Assets/Scripts/Colision.cs
				case "Amarillo":
					Destroy (col.gameObject);
					Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
<<<<<<< HEAD
                    esfera.tag = "b_Amarilla";
                    esfera.GetComponent<Renderer>().material.color = Color.yellow;
				    GameManager.Amarillo--;
=======
                case "Amarillo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Amarillo";
                    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
                    break;
                case "Azul":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD:Assets/Scripts/Colision.cs
                    esfera.tag = "b_Azul";
                    esfera.GetComponent<Renderer>().material.color = Color.blue;
				    GameManager.Azul--;
=======
                    gameObject.tag = "Azul";
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
                    break;
                case "Rojo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD:Assets/Scripts/Colision.cs
                    esfera.tag = "b_Roja";
                    esfera.GetComponent<Renderer>().material.color = Color.red;
				    GameManager.Rojo--;
					break;
=======
                    gameObject.tag = "Rojo";
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    break;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
                case "Fucsia":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD:Assets/Scripts/Colision.cs
                    esfera.tag = "b_Fucsia";
                    esfera.GetComponent<Renderer>().material.color = Color.magenta;
				    GameManager.Fucsia--;
=======
                    gameObject.tag = "Fucsia";
                    gameObject.GetComponent<Renderer>().material.color = Color.magenta;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
                    break;
                case "Blanco":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD:Assets/Scripts/Colision.cs
                    esfera.tag = "b_Blanca";
                    esfera.GetComponent<Renderer>().material.color = Color.white;
					GameManager.Blanco--;
=======
                    RastreadorCubos.inBlanco--;
                    gameObject.tag = "Blanco";
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
                    break;
                case "Verde":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD:Assets/Scripts/Colision.cs
                    esfera.tag = "b_Verde";
                    esfera.GetComponent<Renderer>().material.color = Color.green;
				GameManager.Verde--;
                    break;
            }
        }
        else 
        {
            if (col.gameObject.tag == "Amarillo" && esfera.tag == "b_Amarilla")
=======
                    gameObject.tag = "Verde";
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
        }
        else {
            if (col.gameObject.tag != gameObject.tag && col.gameObject.tag != "Suelo")
            {
                if (col.gameObject.tag != "Blanco")
                    Application.LoadLevel("Final");
            }
            if (col.gameObject.tag == "Amarillo" && gameObject.tag == "Amarillo")
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
=======
					gameObject.tag = "Amarillo";
					gameObject.GetComponent<Renderer>().material.color = Color.yellow;
					GameManager.Amarillo--;
				scriptShake.shaking = true;
				trazo.material.color = Color.yellow;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Azul":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Azul";
					gameObject.GetComponent<Renderer>().material.color = Color.cyan;
					GameManager.Azul--;
				trazo.material.color = Color.cyan;
				scriptShake.shaking = true;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Rojo":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Rojo";
					gameObject.GetComponent<Renderer>().material.color = Color.red;
					GameManager.Rojo--;
				scriptShake.shaking = true;
				trazo.material.color = Color.red;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Fucsia":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Fucsia";
					gameObject.GetComponent<Renderer>().material.color = Color.magenta;
					GameManager.Fucsia--;
				scriptShake.shaking = true;
				trazo.material.color = Color.magenta;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Blanco":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Blanco";
					gameObject.GetComponent<Renderer>().material.color = Color.white;
					GameManager.Blanco--;
				scriptShake.shaking = true;
				trazo.material.color = Color.white;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
				case "Verde":
					Destroy(col.gameObject);
					Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					gameObject.tag = "Verde";
					gameObject.GetComponent<Renderer>().material.color = Color.green;
					GameManager.Verde--;
				scriptShake.shaking = true;
				trazo.material.color = Color.green;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
					break;
			}
		} else {
			if (col.gameObject.tag != gameObject.tag && col.gameObject.tag != "Suelo") {
				if (col.gameObject.tag != "Blanco")
					Application.LoadLevel("Final");
			}
			if (col.gameObject.tag == "Amarillo" && gameObject.tag == "Amarillo") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
>>>>>>> Ruben
				GameManager.cubosDestruidos++;
				GameManager.Amarillo--;
            }
            if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Azul--;
<<<<<<< HEAD
            }
            if (col.gameObject.tag == "Verde" && gameObject.tag == "Verde")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Verde--;
            }
            if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
<<<<<<< HEAD:Assets/Scripts/Colision.cs
				GameManager.cubosDestruidos++;
				GameManager.Fucsia--;
=======
                GameManager.cubosDestruidos++;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
            }
            if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Rojo--;

            }
            if (col.gameObject.tag == "Blanco" && gameObject.tag != "Blanco")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                GameManager.cubosDestruidos++;
<<<<<<< HEAD:Assets/Scripts/Colision.cs
				GameManager.Blanco--;
=======
                RastreadorCubos.inBlanco--;
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
            }
        }
=======
				scriptShake.shaking = true;
				trazo.material.color = Color.yellow;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Azul--;
				scriptShake.shaking = true;
				trazo.material.color = Color.cyan;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Verde" && gameObject.tag == "Verde") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Verde--;
				scriptShake.shaking = true;
				trazo.material.color = Color.green;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Fucsia--;
				scriptShake.shaking = true;
				trazo.material.color = Color.magenta;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Rojo--;
				scriptShake.shaking = true;
				trazo.material.color = Color.red;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
			}
			if (col.gameObject.tag == "Blanco" && gameObject.tag != "Blanco") {
				Destroy(col.gameObject);
				Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				gameObject.GetComponent<Renderer>().material.color = Color.white;
				GameManager.cubosDestruidos++;
				GameManager.Blanco--;
				scriptShake.shaking = true;
				trazo.material.color = Color.white;
				audio.PlayOneShot (puntoAudio, 1F);//Rubén
			}
		}   
>>>>>>> Ruben
    }
}