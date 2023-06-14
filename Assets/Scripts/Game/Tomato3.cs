using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato3 : MonoBehaviour
{
    public static bool isCollected3;
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
        isCollected3 = true;
        //Destroy(gameObject);
    }
}
