using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {
	TextMesh text;
	Color idle = new Color(.094F, .184F, .227F);


	// Use this for initialization
	void Start () {
		text = this.GetComponent<TextMesh> ();
		text.color = idle;
	}

	void Update() {
		RaycastHit hit = new RaycastHit();
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit)) {
			Debug.Log(hit.collider.name+", "+hit.collider.tag);
		}
	}

	void OnMouseEnter() {
		text.color = Color.cyan;
	}

	void OnMouseExit() {
		text.color = idle;
	}
}
