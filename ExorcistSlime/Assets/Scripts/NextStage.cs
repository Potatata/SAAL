using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{

    public int scene;
    bool loaded;

    private void OnTriggerEnter2D()
    {
        Debug.Log("Entro");
        if (!loaded)
        {
            SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
            loaded = true;
        }
        
    }
}
