using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnloadStage : MonoBehaviour
{
    public int scene;
    bool unloaded;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!unloaded)
        {
            unloaded = true;
            AnyManager.anyManager.UnloadScene(scene);
            Destroy(GetComponent<CompositeCollider2D>());
            Destroy(GetComponent<Rigidbody2D>());
        }
    }
    
}
