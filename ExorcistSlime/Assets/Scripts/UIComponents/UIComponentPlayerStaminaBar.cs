using UnityEngine;

public class UIComponentPlayerStaminaBar : UIComponent
{
    public GameObject staminaBar;

    // Start is called before the first frame update
    public override void Start()
    {
        //Sets the health bar in full
        ScaleStaminaBar(new Health { currentHealth = 1, totalHealth = 1 });
        staminaBar = GameObject.FindGameObjectWithTag("StaminaBar");
    }

    /// <summary>
    /// When there are changes in the UI, show
    /// </summary>
    /// <param name="stamina">The new stamina to show</param>
    public override void UpdateUI(Health stamina)
    {
        ScaleStaminaBar(stamina);
    }

    /// <summary>
    /// Method to scale the stamina bar
    /// </summary>
    /// <param name="stamina">The new stamina to show</param>
    public void ScaleStaminaBar(Health stamina)
    {
        staminaBar.transform.localScale = new Vector3(stamina.currentHealth / stamina.totalHealth, 1f);
    }
}
