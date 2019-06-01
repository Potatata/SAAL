using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation
{
    public const int initialHealth = 5;

    public static PlayerInformation instance;

    public static PlayerInformation GetInstance()
    {
        if (instance == null)
        {
            instance = new PlayerInformation();
        }
        return instance;
    }

    public PlayerInformation() { }

    public int health = initialHealth;

    public void DecreasePlayerHealth()
    {
        --health;
    }

    public void RestartGame()
    {
        health = initialHealth;
    }
}
