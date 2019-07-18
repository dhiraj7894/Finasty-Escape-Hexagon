using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private bool touch;
    public float speedTime = 30f;

    private Vector2 ptA;
    private Vector2 ptB;

    public Transform bg;
    public Transform ply;
    private void Start()
    {
        FindObjectOfType<AdManager>().RequestBanner();
    }
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * speedTime);
        if (Input.GetMouseButtonDown(0)) {
            ptA = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

            ply.GetComponent<SpriteRenderer>().enabled = true;
            bg.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (Input.GetMouseButton(0))
        {
            touch = true;
            ptB = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        }
        else {  
            touch = false;
        }
    }
    private void FixedUpdate()
    {
        if (touch)
        {
            Vector2 offset = ptA - ptB;
            Vector2 dir = Vector2.ClampMagnitude(offset, 1f);

            ply.transform.position = new Vector2(ptA.x + dir.x, ptA.y + dir.y) * -1.3f;
        }
    }
    public void stp() {
        ply.transform.gameObject.SetActive(false);
    }
}
