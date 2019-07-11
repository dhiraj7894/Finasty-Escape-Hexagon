using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socialMedia : MonoBehaviour
{
    // Start is called before the first frame update
    public void openFB()
    {
        Application.OpenURL("https://www.facebook.com/GRTEvolution");
    }
    public void openInsta()
    {
        Application.OpenURL("https://www.instagram.com/grtevolution/");
    }
    public void openYT()
    {
        Application.OpenURL("https://www.youtube.com/c/grtevolution");
    }
    public void openGit()
    {
        Application.OpenURL("https://github.com/dhiraj7894");
    }
    public void openRate()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.finasty.makerghat");
    }
    public void privacyOpen()
    {
        Application.OpenURL("https://grtevolution.blogspot.com/2019/07/privacy-policy-of-grt-evolution-this.html");
    }
    public void ashaClick()
    {
        Application.OpenURL("https://mumbai.ashanet.org/");
    }
    public void mGClick()
    {
        Application.OpenURL("https://makerghat.org/");
    }
}
