using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class EllipseRenderer : MonoBehaviour
{
    LineRenderer lr;
    public Ellipse ellipse;

    [Range(3, 36)]
    public int segment;


    void Awake()
    {
        lr = GetComponent<LineRenderer>();
        CalculateEllipse();
    }
    void CalculateEllipse()
    {
        Vector3[] points = new Vector3[segment + 1];
        for (int i = 0; i < segment; i++)
        {
            Vector2 position2D = ellipse.Evaluate ((float)i / (float)segment);
            points[i] = new Vector3(position2D.x, position2D.y, 0f);
        }
        points[segment] = points[0];
        lr.positionCount = segment + 1;
        lr.SetPositions (points);

    }
     void OnValidate()
    {
        if (Application.isPlaying && lr !=null)
        {
            CalculateEllipse();
        }
     }
}
