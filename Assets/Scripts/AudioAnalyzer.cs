using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioAnalyzer : MonoBehaviour {
    AudioSource audioSource;
    public static float[] sampleData = new float[512];
    public static float[] frequenvyBands = new float[8];


	// Use this for initialization
	void Start () {

        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
	}

    void GetSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(sampleData, 0, FFTWindow.Blackman);
    }

    void CreateFrequencyBands()
    {

    }
}
