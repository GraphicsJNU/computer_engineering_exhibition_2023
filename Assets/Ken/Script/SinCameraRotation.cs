using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinCameraRotation : MonoBehaviour
{
    public float rotationAmount = 10;
    public float frequency = 1;
    public int octaves = 2;

    private float time;
    private float rotation;
    private Transform cameraTranform;

    // Start is called before the first frame update
    void Start()
    {
        cameraTranform = GetComponent<Transform>();
        time = Time.time;
        rotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rotation = rotationAmount * Mathf.Sin(frequency * time);
        cameraTranform.rotation = Quaternion.Euler(0, rotation, 0);
        time += Time.deltaTime;
    }
}
