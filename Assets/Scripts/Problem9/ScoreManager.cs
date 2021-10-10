using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace problem9
{
    public class ScoreManager : MonoBehaviour
    {
        public Text playerScore;
        public Text enemyScore;
        private Player player;
        private Ball ball;

        private void Start()
        {
            player = FindObjectOfType<Player>();
            ball = FindObjectOfType<Ball>();
        }

        private void Update()
        {
            playerScore.text = "Score: " + player.currentScore.ToString();
            enemyScore.text = "Counter:" + ball.counter.ToString() + " / " + ball.maxCounter.ToString();
        }
    }

}
