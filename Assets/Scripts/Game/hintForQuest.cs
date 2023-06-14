using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintForQuest : MonoBehaviour
{
    public static bool isAllowdSound;
    private void Start()
    {
        isAllowdSound = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAllowdSound)
        {
            AudioManager.instance.Play("Lvl1Complement");
            isAllowdSound = false;

        }
    }
}
