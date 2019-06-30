using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    private const int firstStage = 1;

    /// <summary>
    /// Starts the game
    /// </summary>
    public void ClickPlayButton()
    {
        AudioManager.GetInstance().ClickSound();
        PauseMenuController.isPaused = false;
        PlayerInformation.GetInstance().RestartGame();
        SceneManager.LoadScene(firstStage);
    }

    /// <summary>
    /// Quits the game
    /// </summary>
    public void ClickQuitButton()
    {
        AudioManager.GetInstance().ClickSound();
        Debug.Log("Hasta la vista");
        Application.Quit();
    }

    /// <summary>
    /// Restarts the game
    /// </summary>
    public void ClickPlayAgainButton()
    {
        AudioManager.GetInstance().ClickSound();
        PlayerInformation.GetInstance().RestartGame();
        SceneManager.LoadScene(firstStage);
    }
}
