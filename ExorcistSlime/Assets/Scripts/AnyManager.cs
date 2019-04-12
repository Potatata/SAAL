using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AnyManager : MonoBehaviour
{
    public static AnyManager anyManager;

    bool gameStart;
    
    //Al iniciar el juego se carga la primera escena
    void Awake()
    {
        if(!gameStart)
        {
            anyManager = this;

            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);

            gameStart = true;
        }
        
    }

    public void UnloadScene(int scene)
    {
        StartCoroutine(Unload(scene));
    }

    IEnumerator Unload(int scene)
    {
        yield return null;

        SceneManager.UnloadScene(scene);
    }
}
