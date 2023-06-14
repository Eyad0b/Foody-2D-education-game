using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifEatingEverything : MonoBehaviour
{
    public GameObject game;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (TomatoLVL2.isCollected && Tomato2LVL2.isCollected && Tomato3LVL2.isCollected && Tomato4LVL2.isCollected)
        {
            game.SetActive(true);
        }
    }
}
