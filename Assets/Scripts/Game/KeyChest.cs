using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyChest : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public static bool isAllowdSound = true;
    public static bool isAllowdSound1 = true;
    public static bool noChestKey;
    public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {
        noChestKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
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
            noChestKey = true;
            if (isAllowdSound)
            {
                AudioManager.instance.Play("grabKey");
                isAllowdSound = false;
            }
            if (!isFollowing)
            {
                PlayerController thePlayer = FindObjectOfType<PlayerController>();

                followTarget = thePlayer.keyChestFollowPoint;

                isFollowing = true;
                thePlayer.followingKeyChest = this;
            }
        }
    }
}
