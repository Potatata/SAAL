public class EnemySidesController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        //Starts all the bullets
        bullets.Add(new BulletSpeed() { Up = 2, Right = 0 });
        bullets.Add(new BulletSpeed() { Up = 0, Right = -2 });
        bullets.Add(new BulletSpeed() { Up = -2, Right = 0 });
        bullets.Add(new BulletSpeed() { Up = 0, Right = 2 });
    }
}
