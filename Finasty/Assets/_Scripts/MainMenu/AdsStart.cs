﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AdManager>().HideBanner();
        FindObjectOfType<AdManager>().RequestVideo();
    }

}