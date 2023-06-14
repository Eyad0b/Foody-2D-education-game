using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuEvents : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;
    public Button button;



    private void Start()
    {
        Time.timeScale = 1;
        mixer.GetFloat("volume",out value);
        volumeSlider.value = value;
    }
    public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);
    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Locked()
    {
        button.interactable = false;
        if (Door.isWinningLVL1)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}
