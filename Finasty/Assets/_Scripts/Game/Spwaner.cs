using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public float spawnRate;
    public GameObject hexagonePrefeb;
    //public GameObject hexagone_1Prefeb;
    //public GameObject hexagone_2Prefeb;
    public float nextTimeToSpawn = 0f;
    public float timer = 1f;
    public void Start()
    {
        hexagonePrefeb.SetActive(true);
    }
    // Update is called once per frame
    private void Update()
    {
        timer = timer + 0.01f;
        //spawnRate = spawnRate + 0.00005f;
        if (Time.time >= nextTimeToSpawn)
        {
            if (timer >= 0.0f)
            {
                Instantiate(hexagonePrefeb, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }   
        }
    }

    public void stop()
    {
       gameObject.SetActive(false);
    }
}
