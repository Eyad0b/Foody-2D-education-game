using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteRender1 : MonoBehaviour
{
    public static SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //if (Tomato.isCollected)
        //{
        //    sprite.color = new Color(255, 255, 255, 255);
        //}
    }
}
