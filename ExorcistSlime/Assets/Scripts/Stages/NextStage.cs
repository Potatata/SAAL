using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{

    public int currentScene;
    bool loaded;

    //Trigger to enter the next stage
    private void OnTriggerEnter2D(Collider2D objectHit)
    {
        if (objectHit.gameObject.GetComponent<PlayerController>())
        {
            //Loads the next stage and unload the old scene
            if (!loaded)
            {
                Debug.Log("Scene loaded!");
                SceneController.anyManager.LoadNextScene(currentScene);
                loaded = true;
            }
        }
    }
}
