using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hundred : MonoBehaviour
{
    public bool destroyOnAwake, findChild = false;
    public float awakeDestroyDelay;

    public string nameChild;
    // Start is called before the first frame update
    void Awake()
    {
        if (destroyOnAwake)
        {
            if (findChild)
            {
                Destroy(transform.Find(nameChild).gameObject);
            }
        }
        else
        {
            Destroy(gameObject, awakeDestroyDelay);
        }
    }

    // Update is called once per frame
    void DestroyChildGameObject()
    {
        if (transform.Find(nameChild).gameObject != null)
            Destroy(transform.Find(nameChild).gameObject);
    }
    void DisableChildGameObject()
    {
        if (transform.Find(nameChild).gameObject.activeSelf == true)
            transform.Find(nameChild).gameObject.SetActive(false);
    }
     void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
