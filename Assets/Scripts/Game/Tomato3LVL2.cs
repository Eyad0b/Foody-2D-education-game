using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato3LVL2 : MonoBehaviour
{
    public static bool isCollected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioManager.instance.Play("drink");
        AudioManager.instance.Play("warning");
        PlayerMovement.isTouched = true;
        isCollected = true;
        Destroy(gameObject);
    }
}
