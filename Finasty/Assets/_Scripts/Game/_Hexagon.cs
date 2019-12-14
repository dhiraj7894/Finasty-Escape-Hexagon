using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed=3f;
    GameManagerGame gM;
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
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x < 0.05f)
        {

            FindObjectOfType<Spawner_1>().Score2();
            FindObjectOfType<GameManagerGame>().scoreInc();
            Destroy(gameObject);
        }

    }
}
