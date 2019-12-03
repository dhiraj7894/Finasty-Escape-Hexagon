using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCrossWord : MonoBehaviour
{
    private Vector3 mousePos;
    private Rigidbody2D rb;
    private Vector2 direction;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePos - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else {
            rb.velocity = Vector2.zero;
        }
    }
    public void stp() {
        gameObject.SetActive(false);
    }
}
