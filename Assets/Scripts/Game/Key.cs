using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public static bool isAllowdSound = true;
    public static bool isAllowdSound1 = true;
    public static bool noKey;
    public static bool noKeyLVL2;
    public Transform followTarget;

    public GameObject game;
    public GameObject game1;
    // Start is called before the first frame update
    void Start()
    {
        noKey = false;
        noKeyLVL2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            game.SetActive(true);
            game1.SetActive(false);
            if (isAllowdSound1)
            {  
                AudioManager.instance.Play("KeyPickup");
                isAllowdSound1 = false;
            }
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            noKey = true;
            noKeyLVL2 = true;
            if (isAllowdSound)
            {
                AudioManager.instance.Play("grabKey");
                isAllowdSound = false;
            }
            if (!isFollowing)
            {
                PlayerController thePlayer = FindObjectOfType<PlayerController>();

                followTarget = thePlayer.keyFollowPoint;

                isFollowing = true;
                thePlayer.followingKey = this;
            }
        }
    }
}
