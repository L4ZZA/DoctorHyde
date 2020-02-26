﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
