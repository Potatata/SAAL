using UnityEngine;
using UnityEngine.UI;

public abstract class CharacterController : MonoBehaviour
{
    //Fields
    public Health health;
    public float movementSpeed;

     public abstract void Move();

}
