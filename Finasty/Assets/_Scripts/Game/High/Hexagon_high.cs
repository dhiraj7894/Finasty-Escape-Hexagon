﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hexagon_high : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float shrinkSpeed;
    public GameManager_High gM;
    public float Score;

    // Start is called before the first frame update
    public void Start()
    {
        Score = 0f;
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
   public void Update()
    {
        shrinkSpeed = shrinkSpeed + 0.005f;
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x < 0.05f) {
            FindObjectOfType<GameManager_High>().scoreInc();
            Destroy(gameObject);
        }
        
    }

}