using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner_1 : MonoBehaviour
{
    int whatToSpwan;
    public float spwanRate = 0.5f;
    public GameObject hexagon1, hexagon2, hexagon3, hexagon4, hexagon5, hexagon6, HundredUI;
    float nextTimeToSpawn = 0f;
    public float Score_1;

    GameManagerGame gML = new GameManagerGame();
    private void Start()
    {
        spwanRate = 0.5f;
        
    }
    void Update()
    { 
        spwanRate = (spwanRate + (1f/100000f));
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
                    Instantiate(hexagon3, Vector3.zero, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(hexagon4, Vector3.zero, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(hexagon5, Vector3.zero, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(hexagon6, Vector3.zero, Quaternion.identity);
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
