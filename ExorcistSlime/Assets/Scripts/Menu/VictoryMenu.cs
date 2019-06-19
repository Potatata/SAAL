using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlayVictorySong();
    }
}
