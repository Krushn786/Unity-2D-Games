﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    [SerializeField] AudioClip breakSound;

    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
        

    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        DestoryBlock();
    }

    private void DestoryBlock()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Destroy(gameObject, 0.05f);
        level.BlockDestoryed();
        FindObjectOfType<GameStatus>().CurrentScore();
    }
}
