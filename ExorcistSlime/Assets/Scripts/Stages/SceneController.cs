using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController anyManager;
    PlayerController player;
    bool gameStart;
    Vector2 initialPlayerPosition = new Vector2(21, 26);
    int numberOfScenes = 4;

    ///// <summary>
    ///// Loads the  first scene when the game starts
    ///// </summary>
    //void Awake()
    //{
    //    if (!gameStart)
    //    {
    //        anyManager = this;

    //        //Loads the first scene
    //        LoadScene(1);
    //        //Sets the player and the player's initial position
    //        player = FindObjectOfType<PlayerController>();
    //        SetPlayerPosition(initialPlayerPosition);
    //        //Set the gameStart bool to true
    //        gameStart = true;
    //    }

    //}

    /// <summary>
    /// Set the player position on the received values
    /// </summary>
    /// <param name="position">A vector with the x, y coordinates where the player's position will be established</param>
    private void SetPlayerPosition(Vector2 position)
    {
        if (player != null)
        {
            player.transform.position = position;
        }
    }

    /// <summary>
    /// Method to load a scene
    /// </summary>
    /// <param name="sceneNumber">An int with the scene number to load</param>
    private void LoadScene(int sceneNumber)
    {
        SceneManager.LoadSceneAsync(sceneNumber, LoadSceneMode.Additive);
        SetPlayerPosition(initialPlayerPosition);
    }

    /// <summary>
    /// Method to unload the scene
    /// </summary>
    /// <param name="sceneNumber">An int with the scene number to unload</param>
    public void UnloadScene(int sceneNumber)
    {
        StartCoroutine(Unload(sceneNumber));
    }

    /// <summary>
    /// Unload the scene
    /// </summary>
    /// <param name="sceneNumber">An int with the scene number to unload</param>
    /// <returns></returns>
    private IEnumerator Unload(int sceneNumber)
    {
        yield return null;

        SceneManager.UnloadSceneAsync(sceneNumber);
    }

    /// <summary>
    /// Loads a random next scene and unload the current scene
    /// </summary>
    /// <param name="currentScene">An int with the current scene number</param>
    public void LoadNextScene(int currentScene)
    {
        System.Random randomNumber = new System.Random();
        int nextScene = randomNumber.Next(1, numberOfScenes + 1);
        Debug.Log("New scene: " + nextScene.ToString() + " Past scene: " + currentScene.ToString());
        UnloadScene(currentScene);
        LoadScene(nextScene);

    }
}
