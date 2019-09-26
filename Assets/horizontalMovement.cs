﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontalMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 velocity;
    public float jumpforce;

    public bool moveCube;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveCube=true;

    }

    // Update is called once per frame
    void Update()
    {
        if (moveCube)
        {
            float h = Input.GetAxis("Horizontal");
            //print(h);
            float v = Input.GetAxis("Vertical");


            transform.Translate(
                h * Time.deltaTime * velocity,
                Space.World
                );
        }
        if (Input.GetKey("b"))
        {
            moveCube = true;
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetKey("n"))
        {
            moveCube = false;
            freezeCube();
        }
        if (Input.GetKey("m"))
        {
            moveCube = false;
            freezeCube();
        }


    }
    public void freezeCube()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
