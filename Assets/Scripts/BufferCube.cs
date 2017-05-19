using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferCube : MonoBehaviour
{

    public int band;
    public float startVal, scaleMultiplier;
    public bool buffer;
    Material material;

    // Use this for initialization
    void Start()
    {
        material = GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (buffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioAnalyzer.buffer[band] * scaleMultiplier) + startVal, transform.localScale.z);
            Color color = new Color(AudioAnalyzer.bufferBand[band], AudioAnalyzer.bufferBand[band], AudioAnalyzer.bufferBand[band]);
            material.SetColor("_EmissionColor", color);
        }
        if (!buffer)
        {
            transform.localScale = new Vector3(transform.localScale.x, (AudioAnalyzer.audioBand[band] * scaleMultiplier) + startVal, transform.localScale.z);
            Color color = new Color(AudioAnalyzer.audioBand[band], AudioAnalyzer.audioBand[band], AudioAnalyzer.audioBand[band]);
            material.SetColor("_EmissionColor", color);
        }
    }
}
