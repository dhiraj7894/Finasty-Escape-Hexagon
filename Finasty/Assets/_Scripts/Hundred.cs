using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hundred : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed = 3f;
    GameManager_Low gM;

    // Start is called before the first frame update
    public void Start()
    {
        transform.localScale =Vector3.one;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.localScale += Vector3.one * shrinkSpeed * Time.deltaTime;
        if (transform.localScale.x > 5f)
        {
            Destroy(gameObject);
        }

    }
}
