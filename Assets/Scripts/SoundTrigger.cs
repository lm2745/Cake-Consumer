using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour {

	public AudioSource mySound; //assign to Inspector 

	// Use this for initialization

	void Update () {
	
		if ( Input.GetKeyDown (KeyCode.Space) ) { 
			if (mySound.isPlaying == false) { 
			mySound.Play (); 
	}
}

	if ( Input.GetKeyDown(KeyCode.Space) ) { 
		mySound.Stop (); 
	} 
} 

void OnTriggerEnter () { 
	mySound.Play (); //play sound upon entering trigger
} 
} 
