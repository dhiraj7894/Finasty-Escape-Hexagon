using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GameManagerGame : MonoBehaviour
{
    bool gameEnd = false;
    public bool isRunning;
    public GameObject endLev;
    public Text endTimerText, endScoreText, timerText, score, highScore;
    float  startTime, stopTime, sTime;
    int sScore_Low;
    public string leaderboard, achievement, achievementRe;

    public void Start()
    {
        TimerReset();
        isRunning = false;
        sTime = Time.time;
        endLev.SetActive(false);
        endTimerText.text = sTime.ToString("f0");
        highScore.text = "High Score : " + ((int)PlayerPrefs.GetInt("HighScore_Low")).ToString(); 
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
        score.text = Sc;
        
        sTime = stopTime + (Time.time - startTime);
        int min = (int)sTime / 60;
        int sec = (int)sTime % 60;

        if (isRunning)
        {
            timerText.text = min.ToString() + ":" + sec.ToString();
        }
        if (sScore_Low == 100)
        {
            Social.ReportProgress(achievementRe, 200f, (bool success)=> { 
            
            });
        }
    }
    public void scoreInc()
    {
        sScore_Low = sScore_Low + 2;
    }
    public void TimerStart()
    {
        if (!isRunning)
        {
            print("START");
            isRunning = true;
            startTime = Time.time;
        }

    }
    public void TimerStop()
    {
        if (isRunning)
        {
            print("STOP");
            isRunning = false;
            stopTime = sTime;
        }
    }
    public void TimerReset()
    {
        print("RESET");
        stopTime = 0;
        isRunning = false;
        timerText.text = "00";
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Out()
    {
        PlayGamesPlatform.Instance.IncrementAchievement(achievement, 10, null);

        foreach (Transform tr in endLev.transform.parent)
        {
            tr.gameObject.SetActive(false);

        }
        endLev.SetActive(true);
        FindObjectOfType<Spawner_1>().stop();
        FindObjectOfType<playerCrossWord>().stp();
        //HighScore
        if (sScore_Low > PlayerPrefs.GetInt("HighScore_Low", 0))
        {
            PlayerPrefs.SetInt("HighScore_Low", sScore_Low);
            highScore.text = "High Score : " + sScore_Low.ToString("f0");     
        }
        //Highscore-end
        sTime = stopTime + (Time.time - startTime);
        int min = (int)sTime / 60;
        int sec = (int)sTime % 60;
        
        if (isRunning){
            endTimerText.text = "Survival Time : " + min.ToString() + ":" + sec.ToString();
        }
        //endTimerText.text = "Time = " + min + ":" + sec;
        string sC = sScore_Low.ToString("f0");
        endScoreText.text = "Score = " + sC;

        if (PlayerPrefs.GetInt("HighScore_Low", 0) == 0)
        {
            return;
        }

        Social.ReportScore(PlayerPrefs.GetInt("HighScore_Low", 1), leaderboard, (bool success) => {
            if (success)
            {
                PlayerPrefs.SetInt("HighScore_Low", 0);
            }
        });

    }
    public void AchivementPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void LeaderBoard()
    {


        Social.ShowLeaderboardUI();
    }
}
