using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiOpenGame : MonoBehaviour
{
    public GameObject pauseOpen;

    // Start is called before the first frame update
    void Start()
    {
        pauseOpen.SetActive(false);   
            
    }

    public void OnPause()
    {
       // FindObjectOfType<Pause>()._Pause();
        pauseOpen.SetActive(true);
    }
    public void onResume()
    {
        //FindObjectOfType<Pause>().Resume();
        pauseOpen.SetActive(false);
    }
}
