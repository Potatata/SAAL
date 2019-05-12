using UnityEngine;

public abstract class UIComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Start();

    /// <summary>
    /// Shows the UI Component
    /// </summary>
    public abstract void Show();

    /// <summary>
    /// Hides the health bar
    /// </summary>
    public abstract void Hide();

    /// <summary>
    /// Updates the UIComponent
    /// </summary>
    /// <param name="health">The health to display</param>
    public abstract void Update(Health health);
}
