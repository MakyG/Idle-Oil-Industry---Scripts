using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud4Speed : MonoBehaviour
{
    public static float ScrollSpeed = 1f;
    Vector2 startPos;
    
    void Start()
    {
        startPos = transform.position;
    }
    
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 40);
        transform.position = startPos + Vector2.right * newPos;
    }
}
