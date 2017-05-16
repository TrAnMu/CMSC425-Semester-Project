using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Terminate());
	}

	IEnumerator Terminate() {
		yield return new WaitForSeconds (3);

		Destroy (gameObject);
	}
}
