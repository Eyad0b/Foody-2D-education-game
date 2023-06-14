using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato4LVL2 : MonoBehaviour
{
    public static bool isCollected;
    public GameObject game;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.instance.Play("Eat");
        PlayerMovement.isTouched = true;
        isCollected = true;
        Destroy(gameObject);
        if (TomatoLVL2.isCollected && Tomato2LVL2.isCollected && Tomato3LVL2.isCollected && Tomato4LVL2.isCollected)
        {
            AudioManager.instance.Play("EatingTooMuch");
        }
    }
}
