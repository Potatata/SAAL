using UnityEngine;
using UnityEngine.UI;

public abstract class CharacterController : MonoBehaviour
{
    //Fields
    public Health health;
    public float movementSpeed;
    public Text healthText;

     public abstract void Move();

}
