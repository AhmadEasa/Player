using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int health;
    private static int playerCount = 0;

      public int InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount = playerCount + 1; 
      
        return health;
    }
    public int Heal(int amount)
    {
        health = health + amount;
        
        Debug.Log(playerName + " it heal by " + amount + " curreent health : " + health);
        return health;
        
    }
    public int Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100; 
            Debug.Log(playerName + " Health is perfect,oh legend ,the current health >>" + health);
        }
        else
        {
            Debug.Log(playerName + " You don't need healing , you are very strong .. !!");
        }
        return health;
    }
    public static int ShowPlayerCount()
    {
        Debug.Log("All the players : " + playerCount);
        return playerCount;
    }





}

