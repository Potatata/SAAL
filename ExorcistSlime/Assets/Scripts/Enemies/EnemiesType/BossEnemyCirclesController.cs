/// <summary>
/// Enemy that shoots at the player
/// </summary>
public class BossEnemyCirclesController : BossController
{
    public override void Awake()
    {
        base.Awake();
        health.totalHealth = health.currentHealth = 10f;
        //Starts the bullet direction type
        //Sides
        bullets.Add(new BulletSetDirection() { Up = 2.2f, Right = 2.2f });
        bullets.Add(new BulletSetDirection() { Up = -2.2f, Right = -2.2f });
        bullets.Add(new BulletSetDirection() { Up = -2.2f, Right = 2.2f });
        bullets.Add(new BulletSetDirection() { Up = 2.2f, Right = -2.2f });

        //Diagonal
        bullets.Add(new BulletSetDirection() { Up = 0, Right = -3 });
        bullets.Add(new BulletSetDirection() { Up = 0, Right = 3 });
        bullets.Add(new BulletSetDirection() { Up = 3, Right = 0 });
        bullets.Add(new BulletSetDirection() { Up = -3, Right = 0 });

        //Semi diagonals
    }

    protected override void MovePattern(EnemyController enemy, PlayerController player)
    {
        EnemyMovePattern enemyMovePattern = new EnemyMoveToPlayer();
        enemyMovePattern.MovePattern(enemy, player);
    }
}
