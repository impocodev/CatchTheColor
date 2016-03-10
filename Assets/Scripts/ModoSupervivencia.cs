using UnityEngine;
using System.Collections;

public class ModoSupervivencia : MonoBehaviour
{
    public GameObject explosion;
    public GameObject esfera = new GameObject();

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
                    break;
			case "Blanco":
					Destroy (col.gameObject);
					Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.3f);
					GameManager.cubosDestruidos++;
					esfera.tag = "b_Blanca";
					esfera.GetComponent<Renderer> ().material.color = Color.white;
					GameManager.Blanco--;
=======
                    gameObject.tag = "Fucsia";
                    gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                    break;
                case "Blanco":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
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
			if (col.gameObject.tag == "Amarillo" && esfera.tag == "b_Amarilla") {
				Destroy (col.gameObject);
				Destroy (Instantiate (explosion, transform.position, Quaternion.identity), 3.3f);
				GameManager.cubosDestruidos++;
				GameManager.Amarillo--;
			}
            if (col.gameObject.tag == "Azul" && esfera.tag == "b_Azul")
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
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
            }
            if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul")
>>>>>>> origin/Rodrigo:Assets/Scripts/ModoSupervivencia.cs
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                GameManager.cubosDestruidos++;
				GameManager.Azul--;
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
    }
}