using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharacterController
{
    public float shootingTimer;
    public GameObject bulletPrefab;
    public Transform firePoint;
    protected List<BulletType> bullets;

    public virtual void Awake()
    {
        bullets = new List<BulletType>() { };
    }

    public void Start()
    {
        StartCoroutine(Shoot());
    }

    public override void Move()
    {
        //TODO add taunt
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            //For every bullet that the enemy will throw
            for (int index = 0; index < bullets.Count; ++index)
            {
                //Creates the bullet
                var bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation).GetComponent<BulletController>();
                bullet.Initialize(bullets[index]);
            }
            yield return new WaitForSeconds(shootingTimer);
        }
    }
}
