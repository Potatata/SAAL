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
        Hide();
    }

    /// <summary>
    /// Shows the UI component
    /// </summary>
    public override void Show()
    {
        ChangeChildRenders(true);
    }

    /// <summary>
    /// Hides or shows all child renders
    /// </summary>
    /// <param name="newStatus">The new status for all the children</param>
    private void ChangeChildRenders(bool newStatus)
    {
        Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
            renderer.enabled = newStatus;
    }

    /// <summary>
    /// Hides the UI component
    /// </summary>
    public override void Hide()
    {
        ChangeChildRenders(false);
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
