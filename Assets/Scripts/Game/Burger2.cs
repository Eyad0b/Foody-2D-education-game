using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger2 : MonoBehaviour
{
    public static GameObject gameObject1;
    public static bool isCollected_2;
    public bool isAllowdSound;
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
        isCollected_2 = true;
    }
}
