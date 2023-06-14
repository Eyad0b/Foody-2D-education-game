using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guiding : MonoBehaviour
{
    public GameObject game;
    public GameObject game2;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public static bool isAllowdSound = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            //AudioManager.instance.Stop("Moveforward");
            AudioManager.instance.Play("MoveBackward");
            isAllowdSound = false;
        }
        if (collision.tag == "Player")
        {
            rightArrow.SetActive(false);
            leftArrow.SetActive(true);
            game.SetActive(false);
            game2.SetActive(true);
        }
    }
}
