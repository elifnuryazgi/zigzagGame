using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform ballpoint;
    Vector3 offset;
   
    private void Start()
    {
        offset = transform.position - ballpoint.position;
    }
    private void FixedUpdate()
    {
        if (ball.isfall == false)
        {
            transform.position = ballpoint.position + offset;
        }
    }
   
}