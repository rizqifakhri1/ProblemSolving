using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace problem9
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody2D rigidBody2D;
        public float speed;
        public int counter;
        public int maxCounter;

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

        private void Update()
        {
            if (counter % maxCounter == 0 && counter!=0)
            {
                speed += 1;
                PushBall();
                counter = 0;
            }
        }
    }

}
