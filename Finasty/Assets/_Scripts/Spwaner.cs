using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour
{
    public float spawnRate;
    public GameObject hexagonePrefeb;
    public GameObject hexagone_1Prefeb;
    public GameObject hexagone_2Prefeb;
    public float nextTimeToSpawn = 0f;
    private float timer = 1f;
    public void Start()
    {
        hexagonePrefeb.SetActive(true);
    }
    // Update is called once per frame
    private void Update()
    {
        timer = timer + 0.01f;
        spawnRate = spawnRate + 0.00015f;
        if (Time.time >= nextTimeToSpawn)
        {
            if (timer >= 0.0f)
            {
                Instantiate(hexagonePrefeb, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
            }
            if (timer >= 25.0f) {
                hexagonePrefeb.SetActive(false);
            }

            if (timer >= 25.5f)
            {
                //CancelInvoke("Spawn");
                Instantiate(hexagone_1Prefeb, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
                hexagone_1Prefeb.SetActive(true);
            }
            if (timer >= 50.5) {
                hexagone_1Prefeb.SetActive(false);
            }
            if (timer >= 51.0f) {

                Instantiate(hexagone_2Prefeb, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
                hexagone_2Prefeb.SetActive(true);
            }



/*
            if (timer > 13.0f)
            {
                hexagone_1Prefeb.SetActive(false);
                hexagone_2Prefeb.SetActive(true);

                Instantiate(hexagone_2Prefeb, Vector3.zero, Quaternion.identity);
                nextTimeToSpawn = Time.time + 1f / spawnRate;
                
            }*/
        }
    }

    public void stop()
    {
       // hexagone_2Prefeb.SetActive(false);
    }
}
