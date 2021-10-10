using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    public GameObject square;
    public int maxSquare;
    public float maxX;
    public float maxY;

    // Rumusan untuk menampilkan random square (SquereSpawner)
    void Start()
    {
        var totalSquare = Random.Range(0,maxSquare);
        for (int i = 0; i < totalSquare; i++)
        {
            var xPosition = Random.Range(-maxX, maxX);
            var yPosition = Random.Range(-maxY, maxY);
            var pos = new Vector2(xPosition, yPosition);
            Instantiate(square,pos,Quaternion.identity);
        }
    }

}
