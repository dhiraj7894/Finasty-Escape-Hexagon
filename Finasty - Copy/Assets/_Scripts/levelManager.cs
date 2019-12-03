using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public Animator trasnitionAnim;
    public Animator trasnitionAnim2;
    //LoadNewLevel_1
    IEnumerator LoadScene()
    {
        
        trasnitionAnim.SetTrigger("FadeOut");
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Game");
    }
    public void loadNewLevel_1()
    {
        StartCoroutine(LoadScene());
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


    //Restart at Low
    public void lowClickRestart()
    {
        FindObjectOfType<GameManager_Low>().endGame();
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
