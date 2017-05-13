using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRunner : MonoBehaviour {
	AudioSource track;

	// Use this for initialization
	void Start () {
		track = GetComponent<AudioSource> ();
		track.PlayDelayed (5.40F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
