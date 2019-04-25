using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDiagonalController : EnemyController
{
    public override void Awake()
    {
        base.Awake();
        //Starts all the bullets
        bullets.Add(new BulletSpeed() { Up = 2, Right = 2 });
        bullets.Add(new BulletSpeed() { Up = -2, Right = -2 });
        bullets.Add(new BulletSpeed() { Up = -2, Right = 2 });
        bullets.Add(new BulletSpeed() { Up = 2, Right = -2 });
    }

    public override void Move()
    {

    }
}
