using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackFreq : MonoBehaviour
{
    public GameObject Track;
    AudioSource _audio;
    public float trackTime;
    public static float[] _samples = new float[512];
    public static float[] _freqBand = new float[8];

    private void Awake()
    {
        _audio = Track.GetComponent<AudioSource>();
    }
    void Update()
    {
        MakeFreqBands();

        trackTime = _audio.time;
        _audio.GetSpectrumData(_samples, 0, FFTWindow.Blackman);

    }

    void MakeFreqBands()
    {
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                average += _samples[count] * (count + 1);
                count++;
            }
            average /= count;
            _freqBand[i] = average * 10;

        }
    }
}
