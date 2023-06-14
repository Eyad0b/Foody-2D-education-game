using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TreasureChest : MonoBehaviour
{
    public Item contents;
    public bool isOpen;
    public GameObject dialogBox;
    public Text dialogText;
    private Animator anim;
    public Collider2D collision;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space") && collision.tag == "Player")
        {
            if (!isOpen)
            {
                OpenChest();
            }
            else
            {
                ChestAlreadyOpen();
            }
        }
    }
    public void OpenChest()
    {
        // Dialog window on
        dialogBox.SetActive(true);
        // dialog text = contents text
        dialogText.text = contents.itemDescription;
        // set the chest to opened
        isOpen = true;
        anim.SetBool("opened", true);
        //storedOpen.RuntimeValue = isOpen;
    }
    public void ChestAlreadyOpen()
    {
        // Dialog off
        dialogBox.SetActive(false);
    }
}
