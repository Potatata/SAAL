using UnityEngine;

public abstract class BulletController : MonoBehaviour
{
    protected BulletType bulletType;
    protected Rigidbody2D rb;

    /// <summary>
    /// Initializes the bullet.
    /// </summary>
    /// <param name="bulletType">The type of bullet this bullet is.</param>
    public void Initialize(BulletType bulletType)
    {
        this.bulletType = bulletType;
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    public abstract void Start();

    /// <summary>
    /// What happens when the bullet hits something
    /// </summary>
    /// <param name="objectHit">What was hit.</param>
    void OnTriggerEnter2D(Collider2D objectHit)
    {

        if (!objectHit.gameObject.GetComponent<EnemyController>() && !objectHit.gameObject.GetComponent<BulletController>())
        {
            Destroy(gameObject);
        }
    }
}