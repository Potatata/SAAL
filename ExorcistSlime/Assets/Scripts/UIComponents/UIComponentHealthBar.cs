using UnityEngine;

public class UIComponentHealthBar : UIComponent
{
    Transform healthBar;

    // Start is called before the first frame update
    public override void Start()
    {
        healthBar = transform.Find("BossBar").transform;
        //Sets the health bar in full
        ScaleHealthBar(new Health { currentHealth = 1, totalHealth = 1 });
    }

    public override void Show()
    {

    }

    public override void Hide()
    {

    }

    public override void Update(Health health)
    {
        ScaleHealthBar(health);
    }

    public void ScaleHealthBar(Health health)
    {
        healthBar.localScale = new Vector3(health.currentHealth / health.totalHealth, 1f);
    }
}
