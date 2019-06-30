using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;

    /// <summary>
    /// Get the status if the game is currently paused or not
    /// </summary>
    /// <returns>The result if the game is paused or not</returns>
    public bool getStatusOfPaused()
    {
        return isPaused;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }
    /// <summary>
    /// Resumes the game
    /// </summary>
    public void Resume()
    {
        AudioManager.GetInstance().ClickSound();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    /// <summary>
    /// Pauses the game
    /// </summary>
    void Pause()
    {
        AudioManager.GetInstance().ClickSound();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    /// <summary>
    /// Goes to main menu
    /// </summary>
    public void GoMainMenu()
    {
        AudioManager.GetInstance().ClickSound();
        isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
