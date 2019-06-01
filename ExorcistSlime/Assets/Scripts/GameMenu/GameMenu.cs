using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    private const int firstStage = 1;
    public void ClickPlayButton()
    {
        SceneManager.LoadScene(firstStage);
    }

    public void ClickQuitButton()
    {
        Application.Quit();
    }

    public void ClickPlayAgainButton()
    {
        PlayerInformation.GetInstance().RestartGame();
        SceneManager.LoadScene(firstStage);
    }
}
