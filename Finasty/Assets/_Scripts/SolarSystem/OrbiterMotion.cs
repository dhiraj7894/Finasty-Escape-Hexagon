using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbiterMotion : MonoBehaviour
{
    public Transform orbitingObject;
    public Ellipse orbitPath;

    [Range (0f, 1f)]
    public float orbiterProgress = 0f;
    public float orbiterPeriod = 3f;
    public bool orbiterActive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if(orbitingObject == null)
        {
            orbiterActive = false;
            return;
        }
        SetOrbiteingObjectPosition();
        StartCoroutine(AnimateOrbit());

    }
    void SetOrbiteingObjectPosition()
    {
        Vector2 orbitPos = orbitPath.Evaluate(orbiterProgress);
        orbitingObject.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);

    }
    IEnumerator AnimateOrbit()
    {
        if (orbiterPeriod < 0.1f)
        {
            orbiterPeriod = 0.1f;
        }

        float orbitSpeed = 1f / orbiterPeriod;
        while (orbiterActive)
        {
            orbiterProgress += Time.deltaTime * orbitSpeed;
            orbiterProgress %= 1f;
            SetOrbiteingObjectPosition();
            yield return null;
        }
    }
}
