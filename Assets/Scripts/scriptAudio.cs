using UnityEngine;
using System.Collections;

public class scriptAudio : MonoBehaviour {
	//public int startingPitch = 10;
	//public int timeToDecrease = 10;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
		audio.pitch = Random.Range(1,2.5f);
	}

	//void Update() {
		/*if (audio.pitch > 0)
			audio.pitch += Time.deltaTime * startingPitch / timeToDecrease;
	}*/
}
