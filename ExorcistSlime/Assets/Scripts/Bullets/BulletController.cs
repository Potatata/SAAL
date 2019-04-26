using UnityEngine;

public abstract class BulletController : MonoBehaviour
{
    public BulletType bulletType;
    protected Rigidbody2D rb;

    public void Initialize(BulletType bulletType)
    {
        this.bulletType = bulletType;
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    public abstract void Start();

    void OnTriggerEnter2D(Collider2D objectHit)
    {

        if (!objectHit.gameObject.GetComponent<EnemyController>() && !objectHit.gameObject.GetComponent<BulletController>())
        {
            Destroy(gameObject);
        }
    }
}