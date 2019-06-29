using System.Collections;
using UnityEngine;

public class SaltController : MonoBehaviour
{
    //Fields
    public float lifeTime = 2.5f;
    public int life = 1;

    public void Start()
    {
        StartCoroutine(Exist());
    }

    private IEnumerator Exist()
    {
        while (true)
        {
            yield return new WaitForSeconds(lifeTime);
            --life;
        }
    }

    void Update()
    {
        if (life <= 0) Destroy(gameObject);
    }
}
