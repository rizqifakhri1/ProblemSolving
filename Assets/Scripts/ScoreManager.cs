using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Script score manager
public class ScoreManager : MonoBehaviour
{
    // Deklarasi Scoretext dan Player
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
