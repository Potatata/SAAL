using UnityEngine;

public abstract class BossController : EnemyController
{
    UIComponent healthBar;

    public override void Start()
    {
        base.Start();
        //Shows the health bar
         GameObject.Find("Canvas").transform.Find("BossHealthBar").gameObject.SetActive(true); ;

        //Gets the health bar element for updates
        healthBar = GameObject.FindGameObjectWithTag("BossHealthBar").GetComponent<UIComponentHealthBar>();

    }

    protected override void TakeDamage()
    {
        base.TakeDamage();
        //Updates the health bar when hit
        healthBar.UpdateUI(health);
    }
}
