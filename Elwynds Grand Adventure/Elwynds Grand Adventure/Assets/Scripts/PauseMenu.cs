using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Script by Brackeys https://www.youtube.com/watch?v=JivuXdrIHK0

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject settingsMenuUI;

    void Start() 
    {
        Resume();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            if (GameIsPaused)
            {
                Resume();
            } else 
            {
                Pause();
            }
        }

    }

    public void Resume() 
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause() 
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Settings() 
    {
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void SettingsBack()
    {
        settingsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void MainMenu() 
    {
        SceneManager.LoadScene("Main Menu");
    }
}
