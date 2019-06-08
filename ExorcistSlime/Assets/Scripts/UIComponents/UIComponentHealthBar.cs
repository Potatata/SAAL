using UnityEngine;

public class UIComponentHealthBar : UIComponent
{
    public GameObject healthBar;

    // Start is called before the first frame update
    public override void Start()
    {
        //Sets the health bar in full
        ScaleHealthBar(new Health { currentHealth = 1, totalHealth = 1 });
        healthBar = GameObject.FindGameObjectWithTag("BossBar");
    }

    /// <summary>
    /// When there are changes in the UI, show
    /// </summary>
    /// <param name="health">The new health to show</param>
    public override void UpdateUI(Health health)
    {
        ScaleHealthBar(health);
    }

    /// <summary>
    /// Method to scale the health bar
    /// </summary>
    /// <param name="health">The new health to show</param>
    public void ScaleHealthBar(Health health)
    {
        healthBar.transform.localScale = new Vector3(health.currentHealth / health.totalHealth, 1f);
    }
}
