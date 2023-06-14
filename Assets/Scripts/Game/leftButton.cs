using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftButton : MonoBehaviour
{
    public GameObject gameObject2;
    public GameObject gameObject3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0f;
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
        }
    }
}

