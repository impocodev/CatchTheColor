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
        }
        else {
            if (col.gameObject.tag == gameObject.tag)
            {
                if (col.gameObject.tag == "Amarillo" && gameObject.tag == "Amarillo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
					GameManager.Amarillo--;
					scriptShake.shaking = true;
					trazo.material.color = Color.yellow;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
                }
                if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
					GameManager.Azul--;
					scriptShake.shaking = true;
					trazo.material.color = Color.cyan;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
					
                }
                if (col.gameObject.tag == "Verde" && gameObject.tag == "Verde")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
					GameManager.Verde--;
					scriptShake.shaking = true;
					trazo.material.color = Color.green;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
                }
                if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
					GameManager.Fucsia--;
					scriptShake.shaking = true;
					trazo.material.color = Color.magenta;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
                }
                if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
					GameManager.Rojo--;
					scriptShake.shaking = true;
					trazo.material.color = Color.red;
					audio.PlayOneShot (puntoAudio, 1F);//Rubén
                }
            }
            if (col.gameObject.tag == "Blanco")
            {
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
    }
}
