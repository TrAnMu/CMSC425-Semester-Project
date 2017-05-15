using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource))]
public class AudioAnalyzer : MonoBehaviour {
    AudioSource audioSource;
    public static float[] sampleData = new float[512];
    float[] frequencyBands = new float[8];
    public static float[] buffer = new float[8];
    private float[] decreaseBuffer = new float[8];
    float[] maxHeight = new float[8];

    public static float[] audioBand = new float[8];
    public static float[] bufferBand = new float[8];


	// Use this for initialization
	void Start () {

        audioSource = GetComponent<AudioSource>();
	}

    void MakeBuffer()
    {
        for(int ctr = 0; ctr < 8; ctr++)
        {
            if(frequencyBands[ctr] >buffer[ctr])
            {
                buffer[ctr] = frequencyBands[ctr];
                decreaseBuffer[ctr] = 0.005f;
            }
            if(frequencyBands[ctr] < buffer[ctr])
            {
                buffer[ctr] -= decreaseBuffer[ctr];
                decreaseBuffer[ctr] *= 1.2f;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        GetSpectrumAudioSource();
        CreateFrequencyBands();
        MakeBuffer();
        CreateAudioBands();
        
	}

    void CreateAudioBands()
    {
        for(int ctr=0; ctr<8; ctr++)
        {
            if(frequencyBands[ctr] > maxHeight[ctr])
            {
                maxHeight[ctr] = frequencyBands[ctr];
            }
            audioBand[ctr] = frequencyBands[ctr] / maxHeight[ctr];
            bufferBand[ctr] = buffer[ctr] / maxHeight[ctr];
        }
    }

    void GetSpectrumAudioSource()
    {
        audioSource.GetSpectrumData(sampleData, 0, FFTWindow.Blackman);
    }

    void CreateFrequencyBands()
    {
        // 44100 /512 = 87 hertz per sample
        /* 20 - 100 hertz
         * 100 - 300 hertz
         * 300 - 700 hertz
         * 700 - 3700 hertz
         * 3700 - 7700 hertz
         * 7700 - 14000 hertz
         * 14000 - 44200 hertz
         * 
         * 0 - 2 : 174
         * 1 - 4 : 348 175-522
         * 2 - 8 : 696 523-1218
         * 3 - 16 : 1392 1219 - 2610
         * 4 - 32 : 2784 2611 - 5394
         * 5 - 64 : 5568 5395 - 10962
         * 6 - 128 : 11136 10963 - 22098
         * 7 - 256 : 22272 - 22099 - 44370
         */
        int counter = 0;
        float average = 0;

        for(int i = 0; i< 8; i++)
        {
            int sampCount = (int)Mathf.Pow(2, i) * 2;
            if(i == 7)
            {
                sampCount += 2;
            }
            for(int ctr = 0; ctr < sampCount; ctr++)
            {
                average += sampleData[counter] * (counter + 1);
                counter++;
            }
            average /= counter;
            frequencyBands[i] = average * 10;
        }

    }
}
