public class EnemyDiagonalController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        //Starts all the bullets
        bullets.Add(new BulletSetDirection() { Up = 2, Right = 2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = -2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = 2 });
        bullets.Add(new BulletSetDirection() { Up = 2, Right = -2 });
    }
}
