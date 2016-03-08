using UnityEngine;
using System.Collections;

public class InterficieInicio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.cubosDestruidos = 0;
        GameManager.cubosLanzados = 0;
        GameManager.tiempoTranscurrido = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Contrareloj ()    {
        Application.LoadLevel("Modo_Contrareloj");
    }

    public void Supervivencia()
    {
        Application.LoadLevel("Modo_Supervivencia");
    }
}
