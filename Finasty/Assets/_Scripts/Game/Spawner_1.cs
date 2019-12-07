using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner_1 : MonoBehaviour
{
    int whatToSpwan;
    public float spwanRate = 0.5f;
    public GameObject hexagon1, hexagon2, hexagon3, hexagon4, hexagon5, hexagon6, HundredUI;
    float nextTimeToSpawn = 0f;
    public float timer = 0.5f,Score_1;

    GameManager_Low gML = new GameManager_Low();
    private void Start()
    {
        spwanRate = 0.5f;
        
    }
    void Update()
    { 
        timer = timer + (1f / 25000f);
        spwanRate = (spwanRate + (1f/80000f));
        //Debug.Log(timer);
        if (Time.time > nextTimeToSpawn)
        {
            whatToSpwan = Random.Range(1, 7);
            switch (whatToSpwan)
            {
                case 1:
                    Instantiate(hexagon1, Vector3.zero, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(hexagon2, Vector3.zero, Quaternion.identity);
                    break;
                case 3:
                    if (timer > 0.55f) {
                        Instantiate(hexagon3, Vector3.zero, Quaternion.identity);
                    }
                    break;
                case 4:
                    if (timer > 0.57f) {
                        Instantiate(hexagon4, Vector3.zero, Quaternion.identity);
                    }
                    break;
                case 5:
                    if (timer > 0.59f) {
                        Instantiate(hexagon5, Vector3.zero, Quaternion.identity);
                    }
                    break;
                case 6:
                    if (timer > 0.62f) {
                        Instantiate(hexagon6, Vector3.zero, Quaternion.identity);
                    }
                        break;

            }
            while (Score_1 == 100)
            {
                Instantiate(HundredUI, Vector3.zero, Quaternion.identity);
                Score_1 = 0f;
            }
            nextTimeToSpawn = Time.time + 1f / spwanRate;
            //Debug.Log(whatToSpwan);
        }
    }
    public void stop()
    {
        gameObject.SetActive(false);
    }
    public void Score2()
    {
        Score_1 = Score_1 + 2f;
    }
}
