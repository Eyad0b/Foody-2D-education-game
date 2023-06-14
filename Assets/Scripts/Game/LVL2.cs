using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LVL2 : MonoBehaviour
{
    public Button button;
    public bool isComplete;
    private void Start()
    {
        isComplete = false;
    }
    private void Update()
    {

    }
    private void OnEnable()
    {
        if (Door.isWinningLVL1)
        {
            gameObject.SetActive(true);
        }
        if (EndDoor.isWinningLVL2)
        {
            gameObject.SetActive(true);
        }
    }
    public void loadScene()
    {
        //if (isComplete)
        //{
        //    SceneManager.LoadScene("Level01");
        //}
    }
    public void loadSceneLVL2()
    {
        if (Door.isWinningLVL1)
        {
            SceneManager.LoadScene("Level02");
        }
    }
}
