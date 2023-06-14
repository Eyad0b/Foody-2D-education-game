using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class isPassedLVLtwo : MonoBehaviour
{
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EndDoor.isWinningLVL2)
        {
            AudioManager.instance.Stop("BackgroundSound");
            star.SetActive(true);
        }
    }
}
