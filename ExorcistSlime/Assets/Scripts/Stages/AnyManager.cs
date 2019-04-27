using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnyManager : MonoBehaviour
{
    public static AnyManager anyManager;

    bool gameStart;
    
    //Loads the  first scene when the game starts
    void Awake()
    {
        if(!gameStart)
        {
            anyManager = this;

            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            //Sets the player's initial position
            GameObject player = GameObject.Find("Player");
            if (player != null)
            {
                player.transform.position = new Vector2(21, 26);
            }
            gameStart = true;

        }
        
    }

    //Method to unload the scene
    public void UnloadScene(int scene)
    {
        StartCoroutine(Unload(scene));
    }

    //Unload the scene
    IEnumerator Unload(int scene)
    {
        yield return null;

        SceneManager.UnloadScene(scene);
    }
}
