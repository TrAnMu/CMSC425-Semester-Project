using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour {
	public bool isMain;
	public bool isQuit;

	void OnMouseUp() {
		if (isMain) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("StartMenu");
		}

		if (isQuit) {
			Application.Quit ();
		}
	}
}
