using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SCORE : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI highScoretext;
    public TextMeshProUGUI yourScoretext;
    public Timing_control timing_control;
    public float highScore;
    public float yourScore;
    
    void Start()
    {
        //if (yourScore <= highScore)
        //{
            //yourScore = highScore;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //highScoretext.text = highScore.ToString("0.00");
        yourScoretext.text = timing_control.timer.ToString("0.00");
    }
}
