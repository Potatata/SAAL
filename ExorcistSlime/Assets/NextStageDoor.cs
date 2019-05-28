using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStageDoor : MonoBehaviour
{
    /// <summary>
    /// Method to destroy the next stage door
    /// </summary>
    public void DestroyDoor()
    {
        Destroy(gameObject);
    }
}
