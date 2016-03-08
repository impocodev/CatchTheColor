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
                case "Amarillo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Amarillo";
                    gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                    break;
                case "Azul":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Azul";
                    gameObject.GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case "Rojo":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Rojo";
                    gameObject.GetComponent<Renderer>().material.color = Color.red;
                    break;
                case "Fucsia":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
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
                    break;

                case "Verde":
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                    gameObject.tag = "Verde";
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
        }
        else {
            if(col.gameObject.tag == gameObject.tag)
            {
                if (col.gameObject.tag == "Amarillo" && gameObject.tag == "Amarillo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                }
                if (col.gameObject.tag == "Azul" && gameObject.tag == "Azul")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                }
                if (col.gameObject.tag == "Verde" && gameObject.tag == "Verde")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                }
                if (col.gameObject.tag == "Fucsia" && gameObject.tag == "Fucsia")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                }
                if (col.gameObject.tag == "Rojo" && gameObject.tag == "Rojo")
                {
                    Destroy(col.gameObject);
                    Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                    GameManager.cubosDestruidos++;
                }
            }
            if (col.gameObject.tag == "Blanco")
            {
                Destroy(col.gameObject);
                Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 3.3f);
                gameObject.GetComponent<Renderer>().material.color = Color.white;
                GameManager.cubosDestruidos++;
                RastreadorCubos.inBlanco--;
            }
        }
    }
}