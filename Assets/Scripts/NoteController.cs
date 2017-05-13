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

    private bool resetTimer = true;
    public float posX;

    List<float> testNotes = new List<float>() { 1, 5, 3, 4, 2, 5, 2, 1, 2, 3, 5, 5, 4, 5, 5, 1, 2, 4, 1, 1, 4, 3 };
    public int notePos = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(resetTimer == true) {
            StartCoroutine(createNote());
            resetTimer = false;
        }
		
	}

    IEnumerator createNote() {
        yield return new WaitForSeconds(1.0F);

        if(testNotes[notePos] == 1) {
            posX = -1.35f;
            objectToCreate = greenNote;
        } 

		if(testNotes[notePos] == 2) {
            posX = -0.65f;
            objectToCreate = redNote;
        } 

		if(testNotes[notePos] == 3) {
            posX = 0f;
            objectToCreate = yellowNote;
        } 

		if(testNotes[notePos] == 4) {
            posX = 0.7f;
            objectToCreate = blueNote;
        } 

		if(testNotes[notePos] == 5) {
            posX = 1.4f;
            objectToCreate = orangeNote;
        }

        notePos++;
        resetTimer = true;
        Instantiate(objectToCreate, new Vector3(posX, 2.55f, 3.28f), objectToCreate.rotation);
    }
}
