using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guiding1 : MonoBehaviour
{
    public GameObject game;
    public GameObject game2;
    public GameObject leftArrow;
    public GameObject jumpArrow;
    public static bool isAllowdSound = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            //AudioManager.instance.Stop("MoveBackward");
            AudioManager.instance.Play("Jump");
            isAllowdSound = false;
        }
        if (collision.tag == "Player")
        {
            leftArrow.SetActive(false);
            jumpArrow.SetActive(true);
            game.SetActive(false);
            game2.SetActive(true);
        }
    }
}
