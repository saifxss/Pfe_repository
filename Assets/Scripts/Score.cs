using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int _x2=1;
    public static int _score=0;
    public static int scoreMulti =1;
    public TextMeshProUGUI Score_text;
    public TextMeshProUGUI Multiplier_text;

    private void Update()
    {
        Score_text.text = _score.ToString();
        if (scoreMulti > 1)
            Multiplier_text.text = scoreMulti.ToString();
        else
            Multiplier_text.text = "";
    }
}
