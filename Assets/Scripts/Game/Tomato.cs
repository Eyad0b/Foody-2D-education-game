using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    public static GameObject gameObject1;
    public static bool isCollected;
    public static bool isAllowdSound;
    private void Start()
    {
        isAllowdSound = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isCollected = true;
        if (isAllowdSound)
        {
            AudioManager.instance.Play("itemPickup");
            isAllowdSound = false;
        }
        //Destroy(gameObject);
    }
}
