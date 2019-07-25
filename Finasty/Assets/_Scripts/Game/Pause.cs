using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu, pauseButton;
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void _Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;  
    }
    public void loadHomeMenu()
    {
        Time.timeScale = 1f;
        FindObjectOfType<levelManager>().homeButtonClick();
    }
    public void ResetHigh()
    {
        Time.timeScale = 1f;
        FindObjectOfType<levelManager>().highClickRestart();
    }
    public void ResetMid()
    {
        Time.timeScale = 1f;
        FindObjectOfType<levelManager>().midClickRestart();
    }
    public void ResetLow()
    {
        Time.timeScale = 1f;
        FindObjectOfType<levelManager>().lowClickRestart();
    }
}
