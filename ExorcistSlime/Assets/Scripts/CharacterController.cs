using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public abstract class CharacterController : MonoBehaviour
{
    //Fields
    public int health;
    public float movementSpeed;
    public Text healthText;


     public abstract void Move();

}
