using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateVisualData : MonoBehaviour {
    public GameObject cubePrefab;
    GameObject[] cubes = new GameObject[512];
    public float maxScale;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < cubes.Length; i++)
        {
            GameObject cubeInstance = (GameObject)Instantiate(cubePrefab);
            cubeInstance.transform.position = this.transform.position;
            cubeInstance.transform.parent = this.transform;
            cubeInstance.name = "Cube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            cubeInstance.transform.position = Vector3.forward * 100;
            cubes[i] = cubeInstance;
        }
		
	}

    // Update is called once per frame
    void Update()
    {
        for (int ctr = 0; ctr < cubes.Length; ctr++)
        {
            if(cubes != null)
            {
                cubes[ctr].transform.localScale = new Vector3(10, (AudioAnalyzer.sampleData[ctr] * maxScale) +2 , 10);
            }
        }
    }
}
