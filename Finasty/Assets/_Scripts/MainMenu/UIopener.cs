using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIopener : MonoBehaviour
{
    public GameObject setting;
    public GameObject support;
    public GameObject qrImg;
    public GameObject credit;
    public GameObject LevOpen;
    public GameObject errorForDeleted;

    public void Start()
    {
        errorForDeleted.SetActive(false);
        LevOpen.SetActive(false);
        support.SetActive(false);
        setting.SetActive(false);
        qrImg.SetActive(false);
        credit.SetActive(false);
    }

    public void settingClick()
    {
        setting.SetActive(true);
    }

    public void LevOpenClick()
    {
        LevOpen.SetActive(true);
    }
    public void supportClick()
    {
        support.SetActive(true);
    }

    public void qrImgClick()
    {
        qrImg.SetActive(true);
    }
    public void creditClick()
    {
        credit.SetActive(true);
    }
    public void errorForDelete() {
        errorForDeleted.SetActive(true);
    }
}
