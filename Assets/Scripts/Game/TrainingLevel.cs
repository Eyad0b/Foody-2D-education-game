using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrainingLevel : MonoBehaviour
{
    public bool isLoading = false;
    private void Start()
    {

    }
    public void loadScene()
    {
        if (Door.isWinningLVL1)
        {
            SceneManager.LoadScene("Level01");
        }else if (!isLoading)
        {
            SceneManager.LoadScene("Training");
            isLoading = true;
        }
    }
    public void LoadLVL1()
    {
        if (nextLVL.LVL1)
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
