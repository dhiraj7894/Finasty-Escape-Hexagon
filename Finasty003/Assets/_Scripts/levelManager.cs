using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public Animator trasnitionAnim;
    public Animator trasnitionAnim2;





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
        trasnitionAnim2.SetTrigger("end");
        trasnitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("_mainMenu");
    }
    public void homeButtonClick()
    {
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

}
