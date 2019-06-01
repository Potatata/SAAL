using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation
{
    private const float initialHealth = 50;

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

    public float health = initialHealth;

    public void DecreasePlayerHealth()
    {
        --health;
    }

    public void RestartGame()
    {
        health = initialHealth;
    }
}
