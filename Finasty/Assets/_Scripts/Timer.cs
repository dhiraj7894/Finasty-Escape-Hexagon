using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text score;
    private float startScore;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        startScore = 0f;
    }

    // Update is called once per frame

        
    void Update()
    {
        startScore = startScore + 1f;

        float t = Time.time - startTime;

        string sC = startScore.ToString();
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");

        timerText.text = "Timer\n" + min + ":" + sec;
        score.text = "Score\n" + sC;
    }
}
