using UnityEngine;
/// <summary>
/// A move pattern that moves to the player until a certain distance.
/// </summary>
public class EnemyMoveToPlayer : EnemyMovePattern
{
    public override void MovePattern(EnemyController enemy, PlayerController player)
    {
        //Moves to the player
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, player.transform.position, enemy.movementSpeed * Time.deltaTime);
    }
}
