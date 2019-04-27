/// <summary>
/// Enemy that shoots at all the diagonals
/// </summary>
public class EnemyDiagonalController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        shootingTimer = 1;
        //Starts all the bullets
        bullets.Add(new BulletSetDirection() { Up = 2, Right = 2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = -2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = 2 });
        bullets.Add(new BulletSetDirection() { Up = 2, Right = -2 });
    }
}
