using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRunner : MonoBehaviour {
	AudioSource track;

	// Use this for initialization
	void Start () {
		int layer = LayerMask.NameToLayer ("Notes");
		Physics.IgnoreLayerCollision (layer, layer, true);
		track = GetComponent<AudioSource> ();
		track.PlayDelayed (5.15F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
