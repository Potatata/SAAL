using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharacterController
{
    public float shootingTimer;
    public GameObject bulletPrefab;

    public void Awake()
    {
        StartCoroutine(Shoot());
    }

    private IEnumerator Shoot()
    {
        while (true)
        {
            Instantiate(bulletPrefab, this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(shootingTimer);
        }
    }
}
