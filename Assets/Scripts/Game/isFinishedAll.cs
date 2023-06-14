using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isFinishedAll : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Door.isWinningLVL1 && EndDoor.isWinningLVL2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            button.interactable = true;
            
        }
        if (Door.isWinningLVL1)
        {
            star1.SetActive(true);
            button.interactable = true;
        }
        if (EndDoor.isWinningLVL2)
        {
            star2.SetActive(true);
            button.interactable = true;
        }
    }
}
