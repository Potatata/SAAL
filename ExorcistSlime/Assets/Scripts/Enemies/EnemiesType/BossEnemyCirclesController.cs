/// <summary>
/// Enemy that shoots at the player
/// </summary>
public class BossEnemyCirclesController : BossController
{
    public override void Awake()
    {
        base.Awake();
        shootingTimer = 4f;
        //Starts the bullet direction type
        bullets.Add(new BulletSetDirection() { Up = 3, Right = 3 });
        bullets.Add(new BulletSetDirection() { Up = 0, Right = 3 });
        bullets.Add(new BulletSetDirection() { Up = 3, Right = 0 });
        bullets.Add(new BulletSetDirection() { Up = -3, Right = -3 });
        bullets.Add(new BulletSetDirection() { Up = -3, Right = 0 });
        bullets.Add(new BulletSetDirection() { Up = 0, Right = -3 });
        bullets.Add(new BulletSetDirection() { Up = -3, Right = 3 });
        bullets.Add(new BulletSetDirection() { Up = 3, Right = -3 });
    }

    protected override void MovePattern(EnemyController enemy, PlayerController player)
    {
        EnemyMovePattern enemyMovePattern = new EnemyMoveToPlayer();
        enemyMovePattern.MovePattern(enemy, player);
    }
}
