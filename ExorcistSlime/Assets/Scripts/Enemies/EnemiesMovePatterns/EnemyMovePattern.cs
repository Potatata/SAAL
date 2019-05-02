public abstract class EnemyMovePattern
{
    /// <summary>
    /// Whick move pattern does the enemy have
    /// </summary>
    /// <param name="enemy">The enemy. Usually is receiving this.</param>
    /// <param name="player">The player in case it needs it.</param>
    public abstract void MovePattern(EnemyController enemy, PlayerController player);
}