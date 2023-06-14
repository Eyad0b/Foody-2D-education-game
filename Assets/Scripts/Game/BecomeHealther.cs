using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BecomeHealther : MonoBehaviour
{
    public GameObject heal;
    public GameObject key;
    public GameObject arrow;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public static int enterCount;
    public static bool isAllowdSound = true;
    public static bool isAllowdSound1 = true;
    private void Start()
    {
        enterCount = 0;
        isAllowdSound = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            rightArrow.SetActive(false);
            leftArrow.SetActive(false);
            AudioManager.instance.Play("JumpEvent");
            isAllowdSound = false;
        }
        if (collision.tag == "Player")
        {
            PlayerMovement.Healther = true;
            enterCount++;
            if (enterCount == 6)
            {
                if (isAllowdSound1)
                {
                    AudioManager.instance.Play("JumpEventDone");
                    isAllowdSound1 = false;
                }
                key.SetActive(true);
                arrow.SetActive(true);
                heal.SetActive(false);
                rightArrow.SetActive(true);
                leftArrow.SetActive(true);
            }
        }
    }
}
