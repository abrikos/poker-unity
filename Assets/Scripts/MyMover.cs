using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMover : MonoBehaviour
{
    public Vector2 startPosition;
    public Vector2 endPosition;
    public float step;
    private float progress;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition, progress);
        progress += step;
    }
}
