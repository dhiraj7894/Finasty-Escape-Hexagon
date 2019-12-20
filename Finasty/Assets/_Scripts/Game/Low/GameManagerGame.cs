using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GameManagerGame : MonoBehaviour
{
    bool gameEnd = false, StatsOpen;
    public bool isRunning;
    public GameObject endLev, Player2, Player3, Stats;
    public Text endTimerText, endScoreText, timerText, score, highScore, scoreUpdate;
    float  startTime, stopTime, sTime;
    int sScore_Low;
    int HexDead = 0;
    public string leaderboard, achievement, achievementRe;

    public void Start()
    {
        Stats.SetActive(false);
        Player2.SetActive(false);
        Player3.SetActive(false);
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
        if (PlayerPrefs.GetInt("HighScore_Low") == 100)
        {
            Social.ReportProgress(GPGSlds.achievement_collect_100_score, 200f, (bool success)=> { 
            
            });
        }
        if (PlayerPrefs.GetInt("HighScore_Low") == 500)
        {
            Social.ReportProgress(GPGSlds.achievement_collect_500_score, 200f, (bool success) => {

            });
        }
        if (PlayerPrefs.GetInt("HighScore_Low") == 1000)
        {
            Social.ReportProgress(GPGSlds.achievement_collect_1000_score, 200f, (bool success) => {

            });
        }
        if (PlayerPrefs.GetInt("HighScore_Low") == 1500)
        {
            Social.ReportProgress(GPGSlds.achievement_collect_1500_score, 200f, (bool success) => {

            });
        }
        if (PlayerPrefs.GetInt("HexDead") > 40) {
            Player2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("HexDead") > 100)
        {
            Player3.SetActive(true);
        }

    }
    public void scoreInc()
    {
        sScore_Low = sScore_Low + 2;
        HexDead++;
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSlds.achievement_hex_finasty_unlocked, 10, null);
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSlds.achievement_ultra_finasty_unlocked, 10, null);
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
        PlayGamesPlatform.Instance.IncrementAchievement(GPGSlds.achievement_xp_bonus, 10, null);

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
        if (HexDead > PlayerPrefs.GetInt("HexDead",0))
        {
            PlayerPrefs.SetInt("HexDead", HexDead);
        }
        //Highscore-end
        sTime = stopTime + (Time.time - startTime);
        int min = (int)sTime / 60;
        int sec = (int)sTime % 60;
        
        if (isRunning){
            endTimerText.text = "Survival Time : " + min.ToString() + ":" + sec.ToString();
        }
        string sC = sScore_Low.ToString("f0");
        endScoreText.text = "Score = " + sC;
        //Post the Score
        if (sScore_Low > PlayerPrefs.GetInt("HighScore_Low", 0))
        {
            postScore();
        }
    }
    public void AchivementPanel()
    {
        Social.ShowAchievementsUI();
    }

    public void LeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void statsOpen()
    {
        if (StatsOpen == false)
        {
            StatsOpen = true;
            Stats.SetActive(true);

        }
        else {
            StatsOpen = false;
            Stats.SetActive(false);
        }
    }
    public void postScore()
    {

            Social.ReportScore(PlayerPrefs.GetInt("HighScore_Low"), GPGSlds.leaderboard_high_score, (bool success) => {
                if (success)
                {
                    //Do not do anything.
                }
            });
        
    }
}
