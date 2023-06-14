using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndDoor : MonoBehaviour
{

    public Signal signalOn;
    public Signal signalOff;
    private PlayerController thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;
    public static bool isWinningLVL2 = false;
    public static bool isAllowdSound = true;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if (Key.noKeyLVL2)
            {
                AudioManager.instance.Stop("Quest");
                signalOff.Raise();
            }
            if (Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) < 0.1f)
            {
                if (isAllowdSound)
                {
                    AudioManager.instance.Play("putKey");
                    AudioManager.instance.Play("openDoor");
                }
                //AudioManager.instance.Play("putKey");
                waitingToOpen = false;

                doorOpen = true;
                theSR.sprite = doorOpenSprite;

                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;

            }
        }
        if (doorOpen && Vector3.Distance(thePlayer.transform.position, transform.position) < 1f)
        {
            if (isAllowdSound)
            {
                AudioManager.instance.Play("levelWin");
                isAllowdSound = false;
            }
            //if (SceneManager.GetActiveScene().name == "Level02")
            //{
            //    isWinningLVL2 = true;
            //}
            isWinningLVL2 = true;
            AudioManager.instance.Play("Money");
            PlayerManager.numberOfCoins += 25;
            PlayerPrefs.SetInt("NumberOfCoins", PlayerManager.numberOfCoins);
            AudioManager.instance.Stop("BackgroundSound");
            SceneManager.LoadScene("END");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!Key.noKeyLVL2)
            {
                AudioManager.instance.Play("Quest");
                signalOn.Raise();
            }
            AudioManager.instance.Play("Quest");
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToOpen = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        signalOff.Raise();
    }
}
