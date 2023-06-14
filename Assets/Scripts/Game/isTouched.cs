using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTouched : MonoBehaviour
{
    public static bool isAllowdSound = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (isAllowdSound)
            {
                AudioManager.instance.Play("MoveForward");
                isAllowdSound = false;
            }
    }
}
