using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socialMedia : MonoBehaviour
{
    // Start is called before the first frame update
    public void openFB()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://www.facebook.com/GRTEvolution");
    }
    public void openInsta()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://www.instagram.com/grtevolution/");
    }
    public void openYT()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://www.youtube.com/c/grtevolution");
    }
    public void openGit()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://github.com/dhiraj7894");
    }
    public void openRate()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.finasty.makerghat");
    }
    public void privacyOpen()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://grtevolution.blogspot.com/2019/07/privacy-policy-of-grt-evolution-this.html");
    }
    public void ashaClick()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://mumbai.ashanet.org/");
    }
    public void mGClick()
    {
        AdManager.instance.RequestVideo();
        Application.OpenURL("https://makerghat.org/");
    }
}
