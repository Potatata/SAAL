using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlayFirstLevelSong();
    }
}
