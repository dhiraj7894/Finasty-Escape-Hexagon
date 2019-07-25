using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Mid : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameManager_Mid>().Out();
    }
}
