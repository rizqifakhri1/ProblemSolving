using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace problem9
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D rigidBody2D;
        public GameObject gameOverPanel;
        public float speed;
        public int currentScore;


        // Start is called before the first frame update
        void Start()
        {
            rigidBody2D = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            var force = new Vector2(0f, 0f);
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.localScale = Vector3.one;
                transform.localRotation = Quaternion.Euler(0,0,90);
                var north = new Vector2(0f, 1f);
                force = north;
                rigidBody2D.velocity = force.normalized * speed;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.localRotation = Quaternion.identity;
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x * -1), transform.localScale.y, transform.localScale.z);
                var east = new Vector2(1f, 0f);
                force = east;
                rigidBody2D.velocity = force.normalized * speed;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                transform.localScale = Vector3.one;
                transform.localRotation = Quaternion.Euler(0, 0, -90);
                var south = new Vector2(0f, -1f);
                force = south;
                rigidBody2D.velocity = force.normalized * speed;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                transform.localRotation = Quaternion.identity;
                transform.localScale = new Vector3(transform.localScale.x*-1,transform.localScale.y, transform.localScale.z);
                var west = new Vector2(-1f, 0f);
                force = west;
                rigidBody2D.velocity = force.normalized * speed;
            }

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var ball = collision.gameObject.GetComponent<Ball>();
            if (ball != null)
            {
                //gameover here
                gameObject.SetActive(false);
                gameOverPanel.SetActive(true);
                Invoke("RestartGame",3f);
            }
        }

        private void RestartGame()
        {
            SceneManager.LoadScene("Problem 9");
        }
    }
}

