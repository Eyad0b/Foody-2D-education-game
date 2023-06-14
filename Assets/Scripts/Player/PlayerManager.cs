using UnityEngine.SceneManagement;
using UnityEngine;
using Cinemachine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;
    public GameObject left;
    public GameObject right;
    public GameObject jump; 
    public GameObject attack;
    public GameObject menu;
    //public GameObject game;
    public static Vector2 lastCheckPointPos = new Vector2(-3,0);

    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;

    public static int numberOfImages;

    public CinemachineVirtualCamera VCam;
    public GameObject[] playerPrefabs;
    int characterIndex;

    private void Awake()
    {
        characterIndex =  PlayerPrefs.GetInt("SelectedCharacter", 0);
        GameObject player =  Instantiate(playerPrefabs[characterIndex], lastCheckPointPos, Quaternion.identity);
        VCam.m_Follow = player.transform;
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
        isGameOver = false;
    }
    private void Start()
    {
        AudioManager.instance.Play("BackgroundSound");
    }
    void Update()
    {
        coinsText.text = numberOfCoins.ToString() ;
        if (isGameOver)
        {
            AudioManager.instance.Play("BackgroundSound");
            gameOverScreen.SetActive(true);
            left.SetActive(false);
            right.SetActive(false);
            jump.SetActive(false);
            attack.SetActive(false);
            menu.SetActive(false);

        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioManager.instance.Stop("BackgroundSound");
        pauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
        AudioManager.instance.Play("BackgroundSound");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //public void GoToMenuFromEnd()
    //{
    //    SceneManager.LoadScene("Menu");
    //    game.SetActive(false);
    //}
}
