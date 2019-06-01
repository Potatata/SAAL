using UnityEngine;

public class UIComponentPlayerStaminaBar : UIComponent
{
    public GameObject staminaBar;

    // Start is called before the first frame update
    public override void Start()
    {
        //Sets the health bar in full
        ScaleHealthBar(new Health { currentHealth = 1, totalHealth = 1 });
        staminaBar = GameObject.FindGameObjectWithTag("StaminaBar");
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
        staminaBar.transform.localScale = new Vector3(health.currentHealth / health.totalHealth, 1f);
    }
}
