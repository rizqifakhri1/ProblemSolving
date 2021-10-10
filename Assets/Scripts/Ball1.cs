using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        PushBall();
    }

    private void PushBall()
    {
        var xForce = Random.Range(-1f, 1f);
        var yForce = Random.Range(-1f, 1f);
        var force = new Vector2(xForce, yForce);
        rigidBody2D.velocity = force.normalized * speed;
    }
}