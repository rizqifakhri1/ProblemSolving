using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float speed;
    private bool isPressed = false;
    public float currentSpeed;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void PushBall()
    {
        if (isPressed) return;

        var force = new Vector2(0f, 0f);
        
        // Arah bola bisa ditekan "W" bola atas
        if (Input.GetKeyDown(KeyCode.W))
        {
            var north = new Vector2(0f, 1f);
            force = north;
            isPressed = true;
        }

        // Arah bola bisa ditekan "D" bola kanan
        else if (Input.GetKeyDown(KeyCode.D))
        {
            var east = new Vector2(1f, 0f);
            force = east;
            isPressed = true;
        }

        // Arah bola bisa ditekan "S" bola bawah
        else if (Input.GetKeyDown(KeyCode.S))
        {
            var south = new Vector2(0f, -1f);
            force = south;
            isPressed = true;
        }

        // Arah bola bisa ditekan ""A bola kiri
        else if (Input.GetKeyDown(KeyCode.A))
        {
            var west = new Vector2(-1f, 0f);
            force = west;
            isPressed = true;
        }

        if (isPressed)
        {
            rigidBody2D.velocity = force.normalized * speed;
        }
    }

    private void Update()
    {
        currentSpeed = rigidBody2D.velocity.magnitude;
        PushBall();
    }
}
