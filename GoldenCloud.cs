using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenCloud : MonoBehaviour
{
    
    public static float ScrollSpeed = 150f;
    Vector2 startPos;
    
    void Start()
    {
        startPos = transform.position;
    }
    
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 20000);
        transform.position = startPos + Vector2.right * newPos;
    }
}
