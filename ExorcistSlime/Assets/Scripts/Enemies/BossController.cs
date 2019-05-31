using UnityEngine;

public abstract class BossController : EnemyController
{
    UIComponent healthBar;

    public override void Start()
    {
        base.Start();
        healthBar = GameObject.FindGameObjectWithTag("BossHealthBar").GetComponent<UIComponentHealthBar>();
        healthBar.Show();
    }

    protected override void TakeDamage()
    {
        base.TakeDamage();
        //Updates the health bar when hit
        healthBar.UpdateUI(health);
        Debug.Log(health.currentHealth);
        Debug.Log(health.totalHealth);
    }
}
