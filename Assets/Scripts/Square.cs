using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        var player = collision.GetComponent<Ball>();
        if (player != null)
        {
            player.currentScore += point;
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        if(squareSpawner.isRespawnable) Invoke("Respawn",3f);
    }

    private void Respawn()
    {
        gameObject.transform.position = squareSpawner.positionInRange();
        gameObject.SetActive(true);
    }
}
