using UnityEngine;

/// <summary>
/// Shoots at the player
/// </summary>
public class BulletShootsAtPlayerController : BulletController
{
    BulletSpeed bulletSpeed;
    PlayerController player;

    public override void Start()
    {
        try
        {
            //Setup
            player = FindObjectOfType<PlayerController>();
            bulletSpeed = (BulletSpeed)bulletType;

            //Shoots at the player direction
            rb.velocity = (player.transform.position - transform.position).normalized * bulletSpeed.Speed;
        }
        catch
        {
            Destroy(gameObject);
        }

    }
}