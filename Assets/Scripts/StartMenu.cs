using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {
	public bool isStart;
	public bool isQuit;

	void OnMouseUp() {
		if (isStart) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("Main");
		}

		if (isQuit) {
			Application.Quit ();
		}
	}
}
