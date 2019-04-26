/// <summary>
/// Enemy that shoots at the player
/// </summary>
public class EnemySimpleShootsAtPlayerController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        shootingTimer = 1;
        //Starts the bullet speed type.
        bullets.Add(new BulletSpeed() { Speed = 2});
    }
}
