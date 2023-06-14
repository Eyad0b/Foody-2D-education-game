using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    public GameObject game;
    public static bool isAllowdSound = true;
    public static bool isAllowdSound1 = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            //AudioManager.instance.Stop("DoubleJump");
            AudioManager.instance.Play("Ready");
            isAllowdSound = false;
        }
        if (collision.tag == "Player")
        {
            game.SetActive(true);
        }
    }
}
