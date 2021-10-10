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

    // Mengarahkan Bola kearah mouse berada
    private void PushBall()
    {
        if (isPressed) return;

        if (Input.GetMouseButtonDown(0))
        {
            isPressed = true;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var force = mouseWorld - transform.position;
            force.z = 0;
            rigidBody2D.velocity = force.normalized * speed;
        }
    }

    private void Update()
    {
        currentSpeed = rigidBody2D.velocity.magnitude;
        PushBall();
    }
}
