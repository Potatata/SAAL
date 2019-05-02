using UnityEngine;
/// <summary>
/// A move pattern that moves to the player until a certain distance.
/// </summary>
public class EnemyMoveToPlayer : EnemyMovePattern
{
    public const float DISTANCE_TILL_PLAYER = 10;

    public override void MovePattern(EnemyController enemy, PlayerController player)
    {
        //Sets if it moves towards or away from the player.
        int direction = (Vector2.Distance(enemy.gameObject.transform.position, player.gameObject.transform.position) > DISTANCE_TILL_PLAYER) ? 1 : -1;
        //Moves in the desired direction
        enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, player.transform.position, enemy.movementSpeed * Time.deltaTime * direction);
    }
}
