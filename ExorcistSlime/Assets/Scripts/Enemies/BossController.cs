using UnityEngine;

public abstract class BossController : EnemyController
{
    UIComponent healthBar;

    public override void Awake()
    {
        SetupAwake();
        healthBar = new UIComponentHealthBar();
        healthBar.Show();
    }

    // Update is called once per frame
    public override void Update()
    {
        Move();
    }

    void OnTriggerEnter2D(Collider2D objectHit)
    {
        //healthBar.Update(health);
    }
}
