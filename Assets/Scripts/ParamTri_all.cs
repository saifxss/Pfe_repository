using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamTri_all : MonoBehaviour
{
    public int _band;
    public float check, more, less;
    public float _startScale, scaleMultiplier;
    public bool ScaleOrOpacity;
   /* public GameObject test1, test2;*/

    void Start()
    {
        ScaleOrOpacity = true;
    }
    private void Update()
    {

        check = trackFreq._freqBand[_band];
        
            if ((more > check) && (check > less))
            {
                transform.localScale = new Vector3((trackFreq._freqBand[_band] * scaleMultiplier) + _startScale, (trackFreq._freqBand[_band] * scaleMultiplier) + _startScale, (trackFreq._freqBand[_band] * scaleMultiplier) + _startScale);
            }
        
        /*if (ScaleOrOpacity == true)
        {
            if ((more > check) && (check > less))
            {
                Instantiate(test1, new Vector3(1777, 0, 0), Quaternion.identity);
                Instantiate(test2, new Vector3(-1777, 0, 0), Quaternion.identity);
                Destroy(test1, 0.1f);
                Destroy(test2, 0.1f);

            }
        }*/


    }
}
