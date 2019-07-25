using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager_High : MonoBehaviour
{

    bool gameEnd = false;
    public GameObject endLev;
    public GameObject image;

    public Text endTimerText;
    public Text endScoreText;
    public float sScore_High;
    public float sTime;
    public Text timerText;
    public Text score;
    //public float incrementValue;
    public Text highScore;


    Spwaner spa = new Spwaner();
    Hexagon_low hex = new Hexagon_low();

    public void Start()
    {
        //sScore = 0f;
        sTime = Time.time;
        spa.spawnRate = 0f;
        hex.shrinkSpeed = 0f;
        endLev.SetActive(false);
        endTimerText.text = sTime.ToString("f2");
        image.SetActive(true);
        highScore.text = "High Score : " + ((int)PlayerPrefs.GetFloat("HighScore_High")).ToString();
    }



    public void endGame()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Invoke("Restart", 0f);
        }

    }
    public void Update()
    {
        //sScore = incrementValue * Time.timeSinceLevelLoad;
        string Sc = sScore_High.ToString("f0");
        float t = Time.time - sTime;
        string sC = sScore_High.ToString();
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");

        timerText.text = "Timer\n" + min + ":" + sec;
        score.text = "Score\n" + Sc;

    }
    public void scoreInc()
    {
        sScore_High = sScore_High + 3f;
    }

    private void Restart()
    {
        sScore_High = 0f;
        spa.spawnRate = 0f;
        hex.shrinkSpeed = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Out()
    {
        foreach (Transform tr in endLev.transform.parent)
        {
            tr.gameObject.SetActive(false);

        }
        endLev.SetActive(true);
        FindObjectOfType<Spwaner>().stop();
        FindObjectOfType<playerCrossWord>().stp();
        //HighScore
        if (sScore_High > PlayerPrefs.GetFloat("HighScore_High", 0))
        {
            PlayerPrefs.SetFloat("HighScore_High", sScore_High);
            highScore.text = "High Score : " + sScore_High.ToString("f0");
        }
        //Highscore-end
        float t = Time.time - sTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");
        endTimerText.text = "Time = " + min + ":" + sec;


        string sC = sScore_High.ToString("f0");
        endScoreText.text = "Score = " + sC;

    }
    public void activateImage()
    {
        image.SetActive(true);
    }
}
