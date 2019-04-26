using UnityEngine;

/// <summary>
/// Shoots at the player
/// </summary>
public class BulletShootsAtPlayerController : BulletController
{
    public BulletSpeed bulletSpeed;
    public PlayerController player;

    public override void Start()
    {
        try
        {
            player = FindObjectOfType<PlayerController>();
            bulletSpeed = (BulletSpeed)bulletType;
            rb.velocity = (player.transform.position - transform.position).normalized * bulletSpeed.Speed;
        }
        catch
        {
            Destroy(gameObject);
        }

    }
}