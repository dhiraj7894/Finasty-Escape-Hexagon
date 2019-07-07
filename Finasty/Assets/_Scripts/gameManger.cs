using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManger : MonoBehaviour
{
    bool gameEnd = false;
    public GameObject endLev;

    public Text endTimerText;
    public Text endScoreText;
    public float sScore;
    public float sTime;
    public Text timerText;
    public Text score;
    public float incrementValue;


    Spwaner spa = new Spwaner();
    Hexagon hex = new Hexagon();

    public void Start()
    {
        sScore = 1f;
        sTime = Time.time;
        spa.spawnRate = 0f;
        hex.shrinkSpeed = 0f;
        endLev.SetActive(false);
        endTimerText.text = sTime.ToString("f2");
    }


  
    public void endGame() {
        if (gameEnd == false) {
            gameEnd = true;
            Invoke("Restart", 0f);
        }

    }
    public void Update()
    {
        sScore = incrementValue * Time.timeSinceLevelLoad;
        string Sc = sScore.ToString("f0");
        float t = Time.time - sTime;
        string sC = sScore.ToString();
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");

        timerText.text = "Timer\n" + min + ":" + sec;
        score.text = "Score\n" + Sc;
    }

    private void Restart()
    {
        spa.spawnRate = 0f;
        hex.shrinkSpeed = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Out() {
        foreach (Transform tr in endLev.transform.parent)
        {
            tr.gameObject.SetActive(false);
        }
        endLev.SetActive(true);
        FindObjectOfType<Spwaner>().stop();
        FindObjectOfType<Player>().stp();

        float t = Time.time - sTime;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");
        endTimerText.text = "Time = "+min + ":" + sec;

        
        string sC = sScore.ToString("f0");
        endScoreText.text = "Score = " + sC;

    }
    public void buttonClick()
    {
        FindObjectOfType<gameManger>().endGame();
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("_Game");
    }
    public void homeClick()
    {
        SceneManager.LoadScene("_mainMenu");  
    }

}

