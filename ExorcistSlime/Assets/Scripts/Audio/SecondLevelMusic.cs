using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlaySecondLevelSong();
    }
}
