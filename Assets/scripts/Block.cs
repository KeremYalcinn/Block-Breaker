using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    Level level;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }
    private void DestroyBlock()
        {
            FindObjectOfType<GameStatus>().AddToScore();
            Destroy(gameObject, 0.1f);
            level.BlockDestroyed();
        }
}




