using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseForGuide : MonoBehaviour
{
    public void pauseGame2(bool x)
{
    if (x)
    {
        Time.timeScale = 0f;
    }
    else
    {
        Time.timeScale = 1f;
    }
}
}
