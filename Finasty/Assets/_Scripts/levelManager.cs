using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    //public Animator trasnitionAnim, trasnitionAnim2;
    public GameObject _Manu, _Player, _GameLevel, Player1, Player2, Player3;

    public void Start()
    {
        _Manu.SetActive(true);
        _Player.SetActive(false);
        _GameLevel.SetActive(false);
        Player1.SetActive(false);
        Player2.SetActive(false);
        Player3.SetActive(false);
    }
    //Restart the Game
    public void lowClickRestart()
    {
        FindObjectOfType<GameManagerGame>().endGame();
    }
    //Quit from the game
    public void quitButton()
    {
        Application.Quit();
    }

    //Delete all the local data you have stored.
    public void resetClick()
    {
        PlayerPrefs.DeleteAll();
    }
    public void startClick_1()
    {
        _Manu.SetActive(false);
        _Player.SetActive(true);
        _GameLevel.SetActive(true);
        Player1.SetActive(true);
    }
    public void startClick_2()
    {
        _Manu.SetActive(false);
        _Player.SetActive(true);
        _GameLevel.SetActive(true);
        Player2.SetActive(true);
    }
    public void startClick_3()
    {
        _Manu.SetActive(false);
        _Player.SetActive(true);
        _GameLevel.SetActive(true);
        Player3.SetActive(true);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Loadlogine()
    {
        SceneManager.LoadScene("_login");
    }

    /*
    //LoadNewLevel_1
    IEnumerator LoadScene()
    {

        trasnitionAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Game");
    }


    IEnumerator homeBtn()
    {
        trasnitionAnim2.SetTrigger("FadeOut");
       // yield return new WaitForSeconds(0.5f);
        trasnitionAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("_mainMenu");
    }
    public void homeButtonClick()
    {
        StartCoroutine(homeBtn());
    }


  }   
    IEnumerator bonus()
    {

        trasnitionAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("_bonusLevel");
    }
    public void BonusButtonClick()
    {
        StartCoroutine(bonus());
    }*/

    //exit

}
