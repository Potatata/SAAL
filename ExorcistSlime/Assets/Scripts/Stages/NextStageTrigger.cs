using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextStageTrigger : MonoBehaviour
{
    private SceneController parentSceneController;

    public void Awake()
    {
        parentSceneController = gameObject.GetComponentInParent<SceneController>();
        if (parentSceneController == null)
            Debug.Log("Parent scene controller not found");
    }

    //Trigger to enter the next stage
    private void OnTriggerEnter2D(Collider2D objectHit)
    {
        if (objectHit.gameObject.GetComponent<PlayerController>())
        {
            //Loads the next stage and unload the old scene
            Debug.Log("Scene loaded!");
            parentSceneController.LoadNextScene();
        }
    }
}
