using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speedRight;
    public float speedUp;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speedRight + transform.up * speedUp;
    }

    void OnTriggerEnter2D(Collider2D objectHit)
    {

        if (!objectHit.gameObject.GetComponent<EnemyController>())
        {
            Destroy(gameObject);
        }
    }
}
