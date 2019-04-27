using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{

    public int scene;
    bool loaded;
    public int oldScene;
    bool pastSceneUnloaded;

    //Trigger to enter the next stage
    private void OnTriggerEnter2D()
    {
        //Loads the next stage and unload the old scene
        if (!loaded)
        {
            Debug.Log("Se cargó la escena");
            GameObject player = GameObject.Find("Player");
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
            //Sets the player position on the top of the level
            if (player != null)
            {
                player.transform.position = new Vector2(21, 26);
            }
            loaded = true;
        }
        if (!pastSceneUnloaded)
        {
            Debug.Log("Se eliminó la escena");
            AnyManager.anyManager.UnloadScene(oldScene);
            pastSceneUnloaded = true;
        }


    }
}
