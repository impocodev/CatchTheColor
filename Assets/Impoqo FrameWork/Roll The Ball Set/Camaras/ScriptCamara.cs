using UnityEngine;
using System.Collections;

public class ScriptCamara : MonoBehaviour {
	private Vector3 myPos;
	//var myPlay : Transform;
	public Transform Objetivo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Objetivo.position + myPos;
	}
}

