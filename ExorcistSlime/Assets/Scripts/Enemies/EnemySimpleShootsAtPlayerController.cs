
public class EnemySimpleShootsAtPlayerController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        //Starts all the bullets
        bullets.Add(new BulletSpeed() { Speed = 10});
    }
}
