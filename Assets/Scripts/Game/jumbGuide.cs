using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumbGuide : MonoBehaviour
{
    public GameObject game;
    public static bool isAllowdSound = true;

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isAllowdSound)
            {
                AudioManager.instance.Play("DoubleJump");
                isAllowdSound = false;
            }
            game.SetActive(false);
        }
    }
}
