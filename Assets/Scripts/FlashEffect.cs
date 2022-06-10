using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashEffect : MonoBehaviour
{
    public int _band;
    public int scaleMultiplier;
    public RawImage rawImg = null;
    public byte alpha = 1;
    private void Update()
    {
        Color color;
        color = new Color32(0,0,255, (byte)(alpha + (trackFreq._freqBand[_band] * scaleMultiplier)));
        if (rawImg) rawImg.color = new Color(rawImg.color.r, rawImg.color.g, rawImg.color.b, color.a);
    }
    
 
    
    
   
        
    

}
