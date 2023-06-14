using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirgeBurgers : MonoBehaviour
{
    public bool playerTouch = false;

    private PlayerController thePlayer;
    public GameObject game;

    public static bool isAllowdSound;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        isAllowdSound = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            if (Burger.isCollected_1)
            {
                SpiriteBurger1.sprite.color = new Color(255f, 255f, 255f, 255f);
                thePlayer.fifthPos.gameObject.SetActive(false);
            }
            if (Burger2.isCollected_2)
            {
                SpiriteBurger2.sprite.color = new Color(255f, 255f, 255f, 255f);
                thePlayer.sixthPos.gameObject.SetActive(false);
            }
            if (Burger3.isCollected_3)
            {
                SpiriteBurger3.sprite.color = new Color(255f, 255f, 255f, 255f);
                thePlayer.seventhPos.gameObject.SetActive(false);
            }
            if (Burger4.isCollected_4)
            {
                SpiriteBurger4.sprite.color = new Color(255f, 174f, 62f, 255f);
                thePlayer.aithPos.gameObject.SetActive(false);
            }
            if (Burger.isCollected_1 && Burger2.isCollected_2 && Burger3.isCollected_3 && Burger4.isCollected_4)
            {
                if (isAllowdSound)
                {
                    AudioManager.instance.Play("SideBurgersEffect");
                    isAllowdSound = false;
                }
                game.SetActive(true);
            }
        }
    }
}
