/// <summary>
/// Shoots at the direction specified
/// </summary>
public class BulletWithSetDirectionController : BulletController
{

    public BulletSetDirection bulletSetDirection;

    public override void Start()
    {
        try
        {
            //Setup
            bulletSetDirection = (BulletSetDirection) bulletType;
            //Shoots the bullet to the specified direction
            rb.velocity = transform.right * bulletSetDirection.Right + transform.up * bulletSetDirection.Up;
        }
        catch
        {
            Destroy(gameObject);
        }
    }
}

