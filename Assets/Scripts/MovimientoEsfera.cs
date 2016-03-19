using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MovimientoEsfera : MonoBehaviour
{
    public float forceValue;
	public float MovX;
	public float MovZ;
    private Rigidbody rigidbody;

	//float speed = 1000.0f;
    // Función que se ejecuta en el inicio.
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
		//Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
		
    void FixedUpdate()
    {
		//this.rigidbody.AddForce(CrossPlatformInputManager.GetAxis("Horizontal") * MovX * Time.deltaTime,0,0);
		//this.rigidbody.AddForce(CrossPlatformInputManager.GetAxis("Vertical") * MovZ * Time.deltaTime,0,0);
		//rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")) * forceValue);
		rigidbody.AddForce(new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"),0,CrossPlatformInputManager.GetAxis("Vertical")) * forceValue);
		//float movimientoX = Input.acceleration.x;
		//float movimientoY = Input.acceleration.y;

		//Vector3 movimiento = new Vector3 (movimientoX, 0.0f, movimientoY);
		//GetComponent<Rigidbody> ().AddForce (movimiento * forceValue * Time.deltaTime);

		//this.transform.Translate(CrossPlatformInputManager.GetAxis("Horizontal") * MovX * Time.deltaTime, 0, 0);

    }

}
