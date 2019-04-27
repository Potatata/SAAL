/// <summary>
/// Enemy that shoots at the sides.
/// </summary>
public class EnemySidesController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        shootingTimer = 1;
        //Starts all the bullets
        bullets.Add(new BulletSetDirection() { Up = 2, Right = 0 });
        bullets.Add(new BulletSetDirection() { Up = 0, Right = -2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = 0 });
        bullets.Add(new BulletSetDirection() { Up = 0, Right = 2 });
    }

}
