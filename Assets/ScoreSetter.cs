using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<TextMesh>().text = PlayerPrefs.GetInt ("score").ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
