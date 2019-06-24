using System.Collections;
using UnityEngine;

public class SaltController : MonoBehaviour
{
    //Fields
    public float lifeTime = 1f;
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
            Debug.Log("Hi!");
            --life;
        }
    }

    void Update()
    {
        if (life <= 0) Destroy(gameObject);
    }
}
