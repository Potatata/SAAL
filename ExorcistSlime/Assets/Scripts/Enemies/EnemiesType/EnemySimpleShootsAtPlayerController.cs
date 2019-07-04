/// <summary>
/// Enemy that shoots at the player
/// </summary>
public class EnemySimpleShootsAtPlayerController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        health.totalHealth = health.currentHealth = 2f;

        //Starts the bullet speed type.
        bullets.Add(new BulletSpeed() { Speed = 4});
    }

    protected override void MovePattern(EnemyController enemy, PlayerController player)
    {
        EnemyMovePattern enemyMovePattern = new EnemyMoveToPlayer();
        enemyMovePattern.MovePattern(enemy, player);
    }

    protected override void TakeDamage()
    {
        base.TakeDamage();
        AudioManager.GetInstance().EnemyDamageSound();
    }
}
