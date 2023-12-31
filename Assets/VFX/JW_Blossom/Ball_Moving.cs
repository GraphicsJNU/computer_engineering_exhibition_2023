using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Moving : MonoBehaviour
{
    Vector3 pos; //현재위치

    public float delta = 50.0f; // 좌(우)로 이동가능한 (x)최대값

    public float speed = 0.35f; // 이동속도




    void Start()
    {

        pos = transform.position;

    }


    void Update()
    {

        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);

        // 좌우 이동의 최대치 및 반전 처리.

        transform.position = v;

    }
}