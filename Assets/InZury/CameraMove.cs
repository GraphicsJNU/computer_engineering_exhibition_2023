using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float cameraSpeed = 1.0f;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        MovePumping();
    }

    private void MovePumping()
    {
        Vector3 cameraPos = new(transform.position.x, transform.position.y, -1.5f + cameraSpeed * Mathf.Cos(0.5f * Time.time));
        transform.position = cameraPos;
    }
}
