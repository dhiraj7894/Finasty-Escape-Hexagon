using UnityEngine;
using System.Collections;

public class PlayerCross : MonoBehaviour
{
    public float speedTime = 30f;
    void Update()
    {
        speedTime = speedTime + (1f / 500f);
        transform.Rotate(Vector3.forward, Time.deltaTime * speedTime);
  }
}
