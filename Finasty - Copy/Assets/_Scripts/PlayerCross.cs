using UnityEngine;
using System.Collections;

public class PlayerCross : MonoBehaviour
{
    public float speedTime = 30f;

    // Update is called once per frame
    void Update()
    {
        speedTime = speedTime + (1f / 500f);
        transform.Rotate(Vector3.forward, Time.deltaTime * speedTime);
  }
}
