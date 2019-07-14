using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public Animator trasnitionAnim;
    public Animator trasnitionAnim2;
    public GameObject setting;
    public GameObject support;
    public GameObject qrImg;
    public GameObject credit;

    public void Start()
    {
        support.SetActive(false);
        setting.SetActive(false);
        qrImg.SetActive(false);
        credit.SetActive(false);
    }

    public void settingClick()
    {
        AdManager.instance.RequestVideo();
        setting.SetActive(true);
    }

    public void supportClick()
    {
        AdManager.instance.RequestVideo();
        support.SetActive(true);
    }

    public void qrImgClick()
    {
        qrImg.SetActive(true);
    }
    public void creditClick()
    {
         AdManager.instance.RequestVideo();
        credit.SetActive(true);
    }

    //LoadNewLevel
    IEnumerator LoadScene()
    {
        
        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("_Game");
    }
    public void loadNewLevel()
    {
        StartCoroutine(LoadScene());
    }

    //HomeButtonClick
    IEnumerator homeBtn()
    {
        AdManager.instance.RequestVideo();
        AdManager.instance.HideBanner();
        trasnitionAnim2.SetTrigger("end");
        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("_mainMenu");
    }
    public void homeButtonClick()
    {
        AdManager.instance.RequestVideo();
        StartCoroutine(homeBtn());
    }



    //buttonClick
    IEnumerator buttonClickd()
    {

        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.5f);
        FindObjectOfType<gameManger>().endGame();
    }
    public void buttonClick()
    {
        StartCoroutine(buttonClickd());
    }

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

}
