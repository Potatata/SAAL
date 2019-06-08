using UnityEngine;

public abstract class UIComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Start();

    /// <summary>
    /// Updates the UIComponent
    /// </summary>
    /// <param name="health">The health to display</param>
    public abstract void UpdateUI(Health health);
}
