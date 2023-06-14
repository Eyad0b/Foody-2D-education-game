using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class isPassedLVLOne : MonoBehaviour
{
    public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Door.isWinningLVL1)
        {
            AudioManager.instance.Stop("BackgroundSound");
            star.SetActive(true);
        }
    }
}
