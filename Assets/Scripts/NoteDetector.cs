using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteDetector : MonoBehaviour {

    public Transform noteBurst;
    public Transform redBurst;
    public Transform blueBurst;
    public Transform greenBurst;
    public Transform yellowBurst;
    public Transform orangeBurst;
    public Transform blackBurst;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "FailBox") {
            Destroy(gameObject);
            Instantiate(blackBurst, transform.position, blackBurst.rotation);
            
        } 

		if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.H)) 
			&& this.gameObject.CompareTag("Green") 
			&& other.gameObject.name == "greenTrigger") {
            Destroy(gameObject);
            Instantiate(greenBurst, transform.position, greenBurst.rotation);
        }
         
		if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.J)) 
			&& this.gameObject.CompareTag("Red") 
			&& other.gameObject.name == "redTrigger") {
            Destroy(gameObject);
            Instantiate(redBurst, transform.position, redBurst.rotation);
        }

		if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.K)) 
			&& this.gameObject.CompareTag("Yellow") 
			&& other.gameObject.name == "yellowTrigger") {
            Destroy(gameObject);
            Instantiate(yellowBurst, transform.position, yellowBurst.rotation);
        }

		if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.L)) 
			&& this.gameObject.CompareTag("Blue") 
			&& other.gameObject.name == "blueTrigger") {
            Destroy(gameObject);
            Instantiate(blueBurst, transform.position, blueBurst.rotation);
        }

		if ((Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.Semicolon)) 
			&& this.gameObject.CompareTag("Orange") 
			&& other.gameObject.name == "orangeTrigger") {
            Destroy(gameObject);
            Instantiate(orangeBurst, transform.position, orangeBurst.rotation);
        }
    }
}
