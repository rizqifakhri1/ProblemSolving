using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public int point;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<Ball>();
        if (player != null)
        {
            player.currentScore += point;
            gameObject.SetActive(false);
        }
    }
}
