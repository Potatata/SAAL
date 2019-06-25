using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFigthMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlayBossSong();
    }
}
