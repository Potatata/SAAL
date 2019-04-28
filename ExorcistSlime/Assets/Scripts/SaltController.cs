using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltController : MonoBehaviour
{
    //Fields
    public int lifeTime = 100;

    void Update()
    {
        --lifeTime;
        Debug.Log(lifeTime);
        if (lifeTime < 0) Destroy(gameObject);
    }
}
