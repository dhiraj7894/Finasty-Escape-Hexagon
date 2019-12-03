using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    public float sScore;
    public float incrementValue;
    // Start is called before the first frame update
    void Start()
    {
        highScore.text = "High Score : "+((int)PlayerPrefs.GetInt("HighScore")).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sScore = incrementValue * Time.timeSinceLevelLoad;
    }

    public void next()
    {
        if (sScore > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", sScore);
            highScore.text = "High Score : " + sScore.ToString("f0");
        }
    }
}
