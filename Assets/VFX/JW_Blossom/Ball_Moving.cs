using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Moving : MonoBehaviour
{
    Vector3 pos; //������ġ

    public float delta = 50.0f; // ��(��)�� �̵������� (x)�ִ밪

    public float speed = 0.35f; // �̵��ӵ�




    void Start()
    {

        pos = transform.position;

    }


    void Update()
    {

        Vector3 v = pos;

        v.x += delta * Mathf.Sin(Time.time * speed);

        // �¿� �̵��� �ִ�ġ �� ���� ó��.

        transform.position = v;

    }
}