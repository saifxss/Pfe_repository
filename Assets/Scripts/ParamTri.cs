using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamTri : MonoBehaviour
{
    public int _band;
    public float _startScale, scaleMultiplier;
    
    private void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, (ObstacleManager._freqBand[_band] * scaleMultiplier) + _startScale, transform.localScale.z);
    }
}
