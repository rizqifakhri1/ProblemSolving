using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace problem9
{
    public class Square : MonoBehaviour
    {
        public int point;
        private SquareSpawner squareSpawner;

        private void Awake()
        {
            squareSpawner = FindObjectOfType<SquareSpawner>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            var player = collision.GetComponent<Player>();
            var ball = collision.GetComponent<Ball>();

            if (player != null)
            {
                player.currentScore += point;
                gameObject.SetActive(false);
            }

            if (ball != null)
            {
                ball.counter += point;
                gameObject.SetActive(false);
            }

        }

        private void OnDisable()
        {
            if (squareSpawner.isRespawnable) Invoke("Respawn", 3f);
        }

        private void Respawn()
        {
            gameObject.transform.position = squareSpawner.positionInRange();
            gameObject.SetActive(true);
        }
    }

}
