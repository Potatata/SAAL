/// <summary>
/// Enemy that shoots at the player
/// </summary>
public class EnemySimpleShootsAtPlayerController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        health.totalHealth = health.currentHealth = 1f;

        //Starts the bullet speed type.
        bullets.Add(new BulletSpeed() { Speed = 2});
    }

    protected override void MovePattern(EnemyController enemy, PlayerController player)
    {
        EnemyMovePattern enemyMovePattern = new EnemyMoveToPlayer();
        enemyMovePattern.MovePattern(enemy, player);
    }
}
