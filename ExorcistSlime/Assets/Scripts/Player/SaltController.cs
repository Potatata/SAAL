using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltController : MonoBehaviour
{
    //Fields
    public float lifeTime = 5f;
    public int life = 1;

    public void Start()
    {
        StartCoroutine(Exist());
    }

    private IEnumerator Exist()
    {
        while (true)
        {
            --life;
            yield return new WaitForSeconds(lifeTime);
        }
    }

    void Update()
    {
        if (life < 0) Destroy(gameObject);
    }
}
