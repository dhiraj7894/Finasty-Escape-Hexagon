using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public Animator trasnitionAnim;
    public Animator trasnitionAnim2;
    //LoadNewLevel_1
    IEnumerator LoadScene()
    {
        
        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("level_low");
    }
    public void loadNewLevel_1()
    {
        StartCoroutine(LoadScene());
    }
    //LoadNewLevel_2
    IEnumerator LoadScene_2()
    {

        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("level_mid");
    }
    public void loadNewLevel_2()
    {
        StartCoroutine(LoadScene_2());
    }

    //LoadNewLevel_1
    IEnumerator LoadScene_3()
    {

        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("level_high");
    }
    public void loadNewLevel_3()
    {
        StartCoroutine(LoadScene_3());
    }
    //HomeButtonClick
    IEnumerator homeBtn()
    {
        trasnitionAnim2.SetTrigger("end");
        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("_mainMenu");
    }
    public void homeButtonClick()
    {
        StartCoroutine(homeBtn());
    }


    //Restart at Low
    public void lowClickRestart()
    {
        FindObjectOfType<GameManager_Low>().endGame();
    }
    //Restart at Mid
    public void midClickRestart()
    {
        FindObjectOfType<GameManager_Mid>().endGame();
    }
    //Restart at high
    public void highClickRestart()
    {
        FindObjectOfType<GameManager_High>().endGame();
    }
    //buttonClick
   /* IEnumerator buttonClickd()
    {

        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.5f);
        
    }
    public void buttonClick()
    {
        StartCoroutine(buttonClickd());
    }*/

    //HighScore

    IEnumerator highScore()
    {

        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("_highScore");
    }
    public void highScoreButtonClick()
    {
        StartCoroutine(highScore());
    }

    //learn
    IEnumerator learn()
    {

        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("_learn");
    }
    public void learnButtonClick()
    {
        StartCoroutine(learn());
    }

    //exit
    public void quitButton()
    {
       
        Application.Quit();
    }
    public void resetClick() {
        PlayerPrefs.DeleteAll();
        Debug.Log("Deleted all data Stored");
    }
}
