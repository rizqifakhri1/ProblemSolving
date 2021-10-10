using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    private Ball player;

    [Header("Square Settings")]
    public GameObject square;
    public int maxSquare;
    public bool isRespawnable;

    [Header("Spawn Area")]
    public float maxX;
    public float maxY;
    public float ballArea;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Ball>();
        var totalSquare = Random.Range(0,maxSquare);
        for (int i = 0; i < totalSquare; i++)
        {
            Instantiate(square,positionInRange(),Quaternion.identity);
        }
    }

    public Vector2 positionInRange()
    {
        var playerPositionX = player.transform.position.x;
        var playerPositionY = player.transform.position.y;
        Vector2 pos;
        do
        {
            var xPosition = Random.Range(-maxX, maxX);
            var yPosition = Random.Range(-maxY, maxY);
            pos = new Vector2(xPosition, yPosition);
        } while (pos.x >= -ballArea + playerPositionX && pos.x <= ballArea + playerPositionX
            && pos.y >= -ballArea + playerPositionY && pos.y <= ballArea + playerPositionY);

        return pos;
    }

}
