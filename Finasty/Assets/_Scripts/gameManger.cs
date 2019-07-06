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

    Spwaner spa = new Spwaner();
    Hexagon hex = new Hexagon();

    public void Start()
    {
        sScore = 0f;
        sTime = Time.time;
        spa.spawnRate = 1f;
        hex.shrinkSpeed = 1f;
        endLev.SetActive(false);
        endTimerText.text = sTime.ToString("f2");
    }
  
    public void endGame() {
        if (gameEnd == false) {
            gameEnd = true;
            Invoke("Restart", 0f);
        }

    }
    private void Update()
    {
        sScore = sScore + 1f;
    }

    private void Restart()
    {
        spa.spawnRate = 1f;
        hex.shrinkSpeed = 1f;
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

        
        string sC = sScore.ToString();
        endScoreText.text = "Score = " + sScore;

    }
    public void buttonClick()
    {
        FindObjectOfType<gameManger>().endGame();
    }

    public void loadLevel()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void homeClick()
    {
        SceneManager.LoadScene("main_menu");  
    }

}

