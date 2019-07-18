using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AdManager>().ShowVideo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
