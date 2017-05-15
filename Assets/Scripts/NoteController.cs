using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour {
	public float bpm;
    public Transform redNote;
    public Transform blueNote;
    public Transform greenNote;
    public Transform yellowNote;
    public Transform orangeNote;
    private Transform objectToCreate;
	private float waitTime;
    private bool resetTimer = true;
    private float posX;
	private int notePos = 0;

	//0, 0, 0, 0, 0, 0, 0, 0
	List<int> noteChart = new List<int>() { 5, 0, 5, 0, 0, 5, 5, 5, 
		3, 0, 3, 0, 0, 3, 3, 3, 
		1, 0, 1, 0, 0, 1, 1, 1, 
		0, 1, 2, 2, 3, 3, 4, 4, 
		3, 0, 3, 0, 0, 3, 0, 0, 
		2, 0, 2, 0, 0, 2, 0, 0,
		4, 0, 4, 0, 0, 4, 0, 4,
		0, 0, 4, 0, 0, 4, 0, 0,
		3, 0, 3, 0, 0, 3, 0, 0,
		2, 0, 2, 0, 0, 2, 0, 0,
		4, 0, 4, 0, 0, 4, 0, 0,
		0, 1, 2, 2, 3, 3, 4, 4,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 0, 3, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 5,
		0, 5, 0, 4, 0, 5, 0, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 0, 3, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 5,
		0, 5, 0, 4, 0, 5, 0, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 0, 3, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 5,
		0, 5, 0, 4, 0, 5, 0, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 0, 3, 2, 2,
		2, 2, 2, 2, 2, 2, 2, 2,
		0, 1, 2, 2, 3, 3, 4, 4,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 3, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 4, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 3, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 1, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 3, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 4, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 3, 0,
		3, 3, 3, 2, 3, 3, 2, 3,
		0, 3, 0, 2, 3, 2, 1, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 4, 3, 2, 2,
		0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 4, 3, 2, 2,
		0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 4, 3, 2, 2,
		0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 0, 0, 0,
		5, 5, 5, 5, 5, 4, 3, 4,
		0, 4, 0, 4, 4, 3, 2, 2,
		0, 2, 0, 2, 2, 2, 2, 2,
		0, 2, 0, 2, 2, 2, 2, 2};

	// Use this for initialization
	void Start () {
		waitTime = (calculateBps (bpm)/ 2.0F) - 0.0509F /*- .05775F*/; // Up for faster, down for slower.
	}
	
	// Update is called once per frame
	void Update () {

        if(resetTimer == true) {
            StartCoroutine(createNote());
            resetTimer = false;
        }
		
	}

<<<<<<< HEAD
	float calculateBps(float bpm) {
		float bps = 60.0F/bpm;

		return bps;
	}

    IEnumerator createNote() {
		yield return new WaitForSeconds(waitTime);

		if (noteChart [notePos] == 1) {
			posX = -1.35f;
			objectToCreate = greenNote;
		} else if (noteChart [notePos] == 2) {
			posX = -0.65f;
			objectToCreate = redNote;
		} else if (noteChart [notePos] == 3) {
			posX = 0f;
			objectToCreate = yellowNote;
		} else if (noteChart [notePos] == 4) {
			posX = 0.7f;
			objectToCreate = blueNote;
		} else if (noteChart [notePos] == 5) {
			posX = 1.4f;
			objectToCreate = orangeNote;
		} else {
			objectToCreate = null;
		}

        notePos++;
        resetTimer = true;

		if (objectToCreate != null) {
			Instantiate (objectToCreate, new Vector3 (posX, 2.55f, 3.28f), objectToCreate.rotation);
		}
=======
    IEnumerator createNote()
    {
        yield return new WaitForSeconds(1);
        if (notePos < testNotes.Count)
        {
            if (testNotes[notePos] == 1)
            {
                posX = -1.35f;
                objectToCreate = greenNote;
            }
            if (testNotes[notePos] == 2)
            {
                posX = -0.65f;
                objectToCreate = redNote;
            }
            if (testNotes[notePos] == 3)
            {
                posX = 0f;
                objectToCreate = yellowNote;
            }
            if (testNotes[notePos] == 4)
            {
                posX = 0.7f;
                objectToCreate = blueNote;
            }
            if (testNotes[notePos] == 5)
            {
                posX = 1.4f;
                objectToCreate = orangeNote;
            }
            notePos++;
            resetTimer = true;
            Instantiate(objectToCreate, new Vector3(posX, 2.55f, 3.28f), objectToCreate.rotation);
        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> master
=======
>>>>>>> master
=======
>>>>>>> master
=======
>>>>>>> master
    }
}
