using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato4 : MonoBehaviour
{
    //public GameObject hint;
    public static bool isCollected4;
    public static bool isAllowdSound;
    private void Start()
    {
        isAllowdSound = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            AudioManager.instance.Play("itemPickup");
            isAllowdSound = false;
        }
        isCollected4 = true;
    }
}
