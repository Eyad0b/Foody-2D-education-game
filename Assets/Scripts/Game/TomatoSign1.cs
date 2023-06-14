using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoSign1 : MonoBehaviour
{
    public Signal signalOn;
    public Signal signalOff;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            signalOn.Raise();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        signalOff.Raise();
    }
}
