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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FailBox")
        {
            Destroy(gameObject);
            Instantiate(blackBurst, transform.position, blackBurst.rotation);
            
        } if(other.gameObject.name == "greenTrigger")
        {
            Destroy(gameObject);
            Instantiate(greenBurst, transform.position, greenBurst.rotation);
        }
         if (other.gameObject.name == "redTrigger")
        {
            Destroy(gameObject);
            Instantiate(redBurst, transform.position, redBurst.rotation);
        }
        if (other.gameObject.name == "yellowTrigger")
        {
            Destroy(gameObject);
            Instantiate(yellowBurst, transform.position, yellowBurst.rotation);
        }
        if (other.gameObject.name == "blueTrigger")
        {
            Destroy(gameObject);
            Instantiate(blueBurst, transform.position, blueBurst.rotation);
        }
        if (other.gameObject.name == "orangeTrigger")
        {
            Destroy(gameObject);
            Instantiate(orangeBurst, transform.position, orangeBurst.rotation);
        }
    }
}
