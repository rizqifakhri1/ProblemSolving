using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace problem9
{
    public class SquareSpawner : MonoBehaviour
    {
        private Player player;

        [Header("Square Settings")]
        public GameObject square;
        public int minSquare;
        public int maxSquare;
        public bool isRespawnable;

        [Header("Spawn Area")]
        public float maxX;
        public float maxY;
        public float playerArea;

        // Start is called before the first frame update
        void Start()
        {
            player = FindObjectOfType<Player>();
            var totalSquare = Random.Range(minSquare, maxSquare);
            for (int i = 0; i < totalSquare; i++)
            {
                Instantiate(square, positionInRange(), Quaternion.identity);
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
            } while (pos.x >= -playerArea + playerPositionX && pos.x <= playerArea + playerPositionX
                && pos.y >= -playerArea + playerPositionY && pos.y <= playerArea + playerPositionY);

            return pos;
        }

    }

}
