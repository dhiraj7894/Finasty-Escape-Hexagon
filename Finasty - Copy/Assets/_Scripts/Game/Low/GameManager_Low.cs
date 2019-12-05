using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager_Low : MonoBehaviour
{
    bool gameEnd = false;
    public GameObject endLev;

    public Text endTimerText, endScoreText, timerText, score, highScore;
    public float sScore_Low, sTime, a;



    Spwaner spa = new Spwaner();
    _Hexagon hex = new _Hexagon();

    public void Start()
    {
        sTime = Time.time;
        spa.spawnRate = 0f;
        hex.shrinkSpeed = 0f;
        endLev.SetActive(false);
        endTimerText.text = sTime.ToString("f0");
        //image.SetActive(true);
        highScore.text = "High Score : " + ((int)PlayerPrefs.GetFloat("HighScore_Low")).ToString();
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
        string Sc = sScore_Low.ToString("f0");
        float t = Time.time - sTime;
        string sC = sScore_Low.ToString();
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");

        timerText.text = min + ":" + sec;
        score.text = Sc;

    }
    public void scoreInc()
    {
        sScore_Low = sScore_Low + 2f;
        a = a + 2f;

    }

    private void Restart()
    {
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
        FindObjectOfType<Spawner_1>().stop();
        FindObjectOfType<playerCrossWord>().stp();

        //HighScore
        if (sScore_Low > PlayerPrefs.GetFloat("HighScore_Low", 0))
        {
            PlayerPrefs.SetFloat("HighScore_Low", sScore_Low);
            highScore.text = "High Score : " + sScore_Low.ToString("f0");
        }

        //Highscore-end
        float t = Time.time - sTime;

        string min = ((int)t / 60).ToString();

        string sec = (t % 60).ToString("f0");

        endTimerText.text = "Time = " + min + ":" + sec;


        string sC = sScore_Low.ToString("f0");

        endScoreText.text = "Score = " + sC;

    }
    /*public void activateImage()
    {
        image.SetActive(true);
    }*/
}
