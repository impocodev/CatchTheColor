using UnityEngine;
using System.Collections;

public class ModoContrareloj : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();
    public GameObject suelo = new GameObject();

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
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Amarillo";
                    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
<<<<<<< HEAD
					GameManager.Amarillo--;
=======
>>>>>>> origin/Rodrigo
                    break;
                case "Azul":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Azul";
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
<<<<<<< HEAD
					GameManager.Azul--;
=======
>>>>>>> origin/Rodrigo
                    break;
                case "Rojo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Rojo";
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
<<<<<<< HEAD
					GameManager.Rojo--;
=======
>>>>>>> origin/Rodrigo
                    break;
                case "Fucsia":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Fucsia";
                    gameObject.GetComponent<Renderer>().material.color = Color.magenta;
<<<<<<< HEAD
					GameManager.Fucsia--;
=======
>>>>>>> origin/Rodrigo
                    break;
                case "Blanco":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
                    gameObject.tag = "Blanco";
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
					GameManager.Blanco--;
=======
                    RastreadorCubos.inBlanco--;
                    gameObject.tag = "Blanco";
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
>>>>>>> origin/Rodrigo
                    break;

                case "Verde":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Verde";
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
<<<<<<< HEAD
					GameManager.Verde--;
=======
>>>>>>> origin/Rodrigo
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
=======
>>>>>>> origin/Rodrigo
                }
                if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Azul--;
					
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
=======
>>>>>>> origin/Rodrigo
                }
                if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Fucsia--;
=======
>>>>>>> origin/Rodrigo
                }
                if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
<<<<<<< HEAD
					GameManager.Rojo--;
=======
>>>>>>> origin/Rodrigo
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
=======
                RastreadorCubos.inBlanco--;
>>>>>>> origin/Rodrigo
            }
        }
    }
}
