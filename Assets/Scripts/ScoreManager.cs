using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private Ball player;

    private void Start()
    {
        player = FindObjectOfType<Ball>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + player.currentScore.ToString();
    }
}
