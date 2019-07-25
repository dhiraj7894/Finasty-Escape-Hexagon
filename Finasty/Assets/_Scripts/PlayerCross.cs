using UnityEngine;

public class PlayerCross : MonoBehaviour
{

    public float speedTime = 30f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedTime = speedTime + 0.0001f;
        transform.Rotate(Vector3.forward, Time.deltaTime * speedTime);
    }
}
