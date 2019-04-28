using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharacterController
{
    public float shootingTimer;
    public GameObject bulletPrefab;
    protected List<BulletType> bullets;
    public bool taunted;
    protected Transform firePoint;
    protected PlayerController player;

    public virtual void Awake()
    {
        bullets = new List<BulletType>() { };
        firePoint = transform.Find("FirePoint").transform;
        player = FindObjectOfType<PlayerController>();
        taunted = false;
        movementSpeed = 1;
    }

    public void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public override void Move()
    {
        if (taunted)
            InTaunt();
        else
            MovePattern(movementSpeed);
    }

    /// <summary>
    /// MovePattern of the current enemy
    /// </summary>
    /// <param name="speed">How fast does it move</param>
    private void MovePattern(float speed)
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
    }

    /// <summary>
    /// When the enemy is taunted. Follows the player.
    /// </summary>
    public void InTaunt()
    {

    }

    /// <summary>
    /// Shoots at the enemy
    /// </summary>
    /// <returns>IEnumerator for the Coroutine</returns>
    private IEnumerator Shoot()
    {
        while (true)
        {
            //For every bullet that the enemy will throw
            for (int index = 0; index < bullets.Count; ++index)
            {
                //Creates the bullet
                var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation).GetComponent<BulletController>();
                bullet.gameObject.layer = 8;
                bullet.Initialize(bullets[index]);
            }
            yield return new WaitForSeconds(shootingTimer);
        }
    }
}
