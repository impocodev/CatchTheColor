using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();
    public GameObject suelo = new GameObject();

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
                    esfera.tag = "b_Amarilla";
                    esfera.GetComponent<Renderer>().material.color = Color.yellow;
				    GameManager.Amarillo--;
                    break;
                case "Azul":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Azul";
                    esfera.GetComponent<Renderer>().material.color = Color.blue;
				    GameManager.Azul--;
                    break;
                case "Rojo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Roja";
                    esfera.GetComponent<Renderer>().material.color = Color.red;
				    GameManager.Rojo--;
					break;
                case "Fucsia":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Fucsia";
                    esfera.GetComponent<Renderer>().material.color = Color.magenta;
				    GameManager.Fucsia--;
                    break;
                case "Blanco":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Blanca";
                    esfera.GetComponent<Renderer>().material.color = Color.white;
					GameManager.Blanco--;
                    break;
                case "Verde":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    esfera.tag = "b_Verde";
                    esfera.GetComponent<Renderer>().material.color = Color.green;
				GameManager.Verde--;
                    break;
            }
        }
        else 
        {
            if (col.gameObject.tag == "Amarillo" && esfera.tag == "b_Amarilla")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Amarillo--;
            }
            if (col.gameObject.tag == "Azul" && esfera.tag == "b_Azul")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Azul--;
            }
            if (col.gameObject.tag == "Verde" && esfera.tag == "b_Verde")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Verde--;
            }
            if (col.gameObject.tag == "Fucsia" && esfera.tag == "b_Fucsia")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Fucsia--;
            }
            if (col.gameObject.tag == "Rojo" && esfera.tag == "b_Roja")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Rojo--;

            }
            if (col.gameObject.tag == "Blanco")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                esfera.GetComponent<Renderer>().material.color = Color.white;
                GameManager.cubosDestruidos++;
				GameManager.Blanco--;
            }
        }
    }
}
