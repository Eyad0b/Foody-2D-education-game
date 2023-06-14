using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato2 : MonoBehaviour
{
    public static bool isCollected2;
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
        isCollected2 = true;
        //Destroy(gameObject);
    }
}
