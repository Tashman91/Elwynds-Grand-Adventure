using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctions : MonoBehaviour
{
    // Script created by Brackeys https://www.youtube.com/watch?v=zc8ac_qUXQY

    public void PlayGame() 
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

    public void ReturnMenu() 
    {
        SceneManager.LoadScene("Main Menu");
    }

}
