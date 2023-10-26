using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        MovePumping();
    }

    private void MovePumping()
    {
        Vector3 cameraPos = new(transform.position.x, transform.position.y, -2.0f + 0.5f * Mathf.Cos(0.5f * Time.time));
        transform.position = cameraPos;
    }
}
