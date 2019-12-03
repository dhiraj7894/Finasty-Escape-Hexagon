using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Rotation : MonoBehaviour
    
{
    public float speedTime = 30f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * speedTime);
        
    }
}
