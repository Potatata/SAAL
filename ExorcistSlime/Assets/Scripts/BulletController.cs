using UnityEngine;

public class BulletController : MonoBehaviour
{
    public BulletSpeed bulletSpeed;
    public Rigidbody2D rb;

    public void Initialize(BulletSpeed bulletSpeed)
    {
        this.bulletSpeed = bulletSpeed;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * bulletSpeed.Right + transform.up * bulletSpeed.Up;
    }

    void OnTriggerEnter2D(Collider2D objectHit)
    {

        if (!objectHit.gameObject.GetComponent<EnemyController>()  && !objectHit.gameObject.GetComponent<BulletController>())
        {
            Destroy(gameObject);
        }
    }
}
