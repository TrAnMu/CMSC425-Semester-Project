using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NoteDetector : MonoBehaviour {

    public Transform noteBurst;
    public Transform redBurst;
    public Transform blueBurst;
    public Transform greenBurst;
    public Transform yellowBurst;
    public Transform orangeBurst;
    public Transform blackBurst;
    private static int score;
    private static int streak;
    private static int multiplier;
    public static NoteController noteScript;
   

	// Use this for initialization
	void Start () {
        score = 0;
        streak = 0;
        multiplier = 1;
        noteScript = GameObject.Find("Board").GetComponent<NoteController>();


    }
	
	// Update is called once per frame
	void Update () {

	}

    void updateMultiplier()
    {
        streak += 1;
        if(streak == 6 || streak == 12 || streak == 18)
        {
            multiplier += 1;
        }
    }

    void addScore()
    {
        score = score + (multiplier * 25);
    }

    void resetMultiplier()
    {
        streak = 0;
        multiplier = 1;
    }


    void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "FailBox") {
            Destroy(gameObject);
            Instantiate(blackBurst, transform.position, blackBurst.rotation);
            resetMultiplier();
            noteScript.scoreText.text = "x" + multiplier.ToString() + "   " + score.ToString();

        } 

		if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.H)) 
			&& this.gameObject.CompareTag("Green") 
			&& other.gameObject.name == "greenTrigger") {
            Destroy(gameObject);
            Instantiate(greenBurst, transform.position, greenBurst.rotation);
            updateMultiplier();
            addScore();
            noteScript.scoreText.text = "x" + multiplier.ToString() + "   " + score.ToString();

        }
         
		if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.J)) 
			&& this.gameObject.CompareTag("Red") 
			&& other.gameObject.name == "redTrigger") {
            Destroy(gameObject);
            Instantiate(redBurst, transform.position, redBurst.rotation);
            updateMultiplier();
            addScore();
            noteScript.scoreText.text = "x" + multiplier.ToString() + "   " + score.ToString();
        }

		if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.K)) 
			&& this.gameObject.CompareTag("Yellow") 
			&& other.gameObject.name == "yellowTrigger") {
            Destroy(gameObject);
            Instantiate(yellowBurst, transform.position, yellowBurst.rotation);
            updateMultiplier();
            addScore();
            noteScript.scoreText.text = "x" + multiplier.ToString() + "   " + score.ToString();
        }

		if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.L)) 
			&& this.gameObject.CompareTag("Blue") 
			&& other.gameObject.name == "blueTrigger") {
            Destroy(gameObject);
            Instantiate(blueBurst, transform.position, blueBurst.rotation);
            updateMultiplier();
            addScore();
            noteScript.scoreText.text = "x" + multiplier.ToString() + "   " + score.ToString();
        }

		if ((Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.Semicolon)) 
			&& this.gameObject.CompareTag("Orange") 
			&& other.gameObject.name == "orangeTrigger") {
            Destroy(gameObject);
            Instantiate(orangeBurst, transform.position, orangeBurst.rotation);
            updateMultiplier();
            addScore();
            noteScript.scoreText.text = "x" + multiplier.ToString() + "   " + score.ToString();
        }
    }
}
