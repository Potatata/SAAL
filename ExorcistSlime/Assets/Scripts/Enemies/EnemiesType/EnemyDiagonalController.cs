/// <summary>
/// Enemy that shoots at all the diagonals
/// </summary>
public class EnemyDiagonalController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        health.totalHealth = health.currentHealth = 1f;

        //Starts all the bullets
        bullets.Add(new BulletSetDirection() { Up = 2, Right = 2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = -2 });
        bullets.Add(new BulletSetDirection() { Up = -2, Right = 2 });
        bullets.Add(new BulletSetDirection() { Up = 2, Right = -2 });
    }

    protected override void MovePattern(EnemyController enemy, PlayerController player)
    {
        EnemyMovePattern enemyMovePattern = new EnemyMoveToPlayer();
        enemyMovePattern.MovePattern(enemy, player);
    }
}
