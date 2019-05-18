using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Assets.Scripts.MarkovChain;

public abstract class SceneController : MonoBehaviour
{
    
    public GameObject playerPrefab;
    public GameObject playerRespawn;
    protected int numberOfScenes = 4;
    protected int currentScene;
    

    public virtual void Awake()
    {
        if(playerPrefab != null && playerRespawn != null)
        {
            Instantiate(playerPrefab, playerRespawn.transform.position, playerRespawn.transform.rotation);
        }

        currentScene = SceneManager.GetActiveScene().buildIndex;
                
    }

    /// <summary>
    /// Method to load a scene
    /// </summary>
    /// <param name="sceneNumber">An int with the scene number to load</param>
    private void LoadScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    /// <summary>
    /// Loads a random next scene and unload the current scene
    /// </summary>
    public void LoadNextScene()
    {
        MarkovNextStage nextStageGenerator = new MarkovNextStage();
        System.Random randomNumber = new System.Random();
        int nextScene = nextStageGenerator.getNextState(currentScene);
        Debug.Log("New scene: " + (nextScene).ToString() + " Past scene: " + (currentScene).ToString());
        LoadScene(nextScene);
    }
    

    
}
