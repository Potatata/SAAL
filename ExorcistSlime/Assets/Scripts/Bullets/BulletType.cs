/// <summary>
/// Different types of bullet types. Each one has certain parameters for certain functions.
/// </summary>
public abstract class BulletType{}

/// <summary>
/// Bullets with set directions. Gives each speed per direction.
/// </summary>
public class BulletSetDirection : BulletType
{

    /// <summary>
    /// Up direction of the bullet
    /// </summary>
    public int Up { get; set; }

    /// <summary>
    /// Right direction of the bullet
    /// </summary>
    public int Right { get; set; }
}

/// <summary>
/// Bullets that only need speed.
/// </summary>
public class BulletSpeed : BulletType
{
    /// <summary>
    /// Speed of the bullet
    /// </summary>
    public int Speed { get; set; }
}