﻿using UnityEngine;
using System.Collections;

public class scriptShake : MonoBehaviour {

	private Vector3 originPosition;
	private Quaternion originRotation;
	public float shake_decay;
	public float shake_intensity;
	public static bool shaking = false;

	void Update (){
		if (shake_intensity > 0) {
			transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
			transform.rotation = new Quaternion (
				originRotation.x + Random.Range (-shake_intensity, shake_intensity) * .2f,
				originRotation.y + Random.Range (-shake_intensity, shake_intensity) * .2f,
				originRotation.z + Random.Range (-shake_intensity, shake_intensity) * .2f,
				originRotation.w + Random.Range (-shake_intensity, shake_intensity) * .2f);
			shake_intensity -= shake_decay;
		} 
		else if (shaking) {
			Shake ();
			shaking = false;
		}
	}

	void Shake(){
		originPosition = transform.position;
		originRotation = transform.rotation;
		shake_intensity = .05f;
		shake_decay = 0.001f;
	}
}
