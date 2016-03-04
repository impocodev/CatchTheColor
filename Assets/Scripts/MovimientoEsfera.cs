using UnityEngine;
using System.Collections;

public class MovimientoEsfera : MonoBehaviour
{

    public float forceValue;
    private Rigidbody rigidbody;

	float speed = 1000.0f;
    // Función que se ejecuta en el inicio.
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
		Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Función llamada una vez por frame.
    void Update()
    {

    }

    void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
                                        0,
                                        Input.GetAxis("Vertical")) * forceValue);
		float movimientoX = Input.acceleration.x;
		float movimientoY = Input.acceleration.y;

		Vector3 movimineto = new Vector3 (movimientoX, 0.0f, movimientoY);
		GetComponent<Rigidbody> ().AddForce (movimineto * speed * Time.deltaTime);
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")) * forceValue);
		//float movimientoX = Input.acceleration.x;
		//float movimientoY = Input.acceleration.y;

		//Vector3 movimineto = new Vector3 (movimientoX, 0.0f, movimientoY);
	//	GetComponent<Rigidbody> ().AddForce (movimineto * speed * Time.deltaTime);
	

		
    }
}
