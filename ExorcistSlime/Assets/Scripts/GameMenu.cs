using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public int firstStage;
    public void ClickPlayButton()
    {
        SceneManager.LoadScene(firstStage);
    }

    public void ClickQuitButton()
    {
        Debug.Log("Se cierra el juego");
        Application.Quit();
    }
}
