using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   void Start()
    {

     Player strongPlayer = new Player();
     Player weakPlayer = new Player();


     strongPlayer.InitializePlayer("strongPlayer", 90);
     weakPlayer.InitializePlayer("weakPlayer", 60);

     strongPlayer.Heal(10);
     weakPlayer.Heal(true); 
     strongPlayer.Heal(false); // just for enjoy :) 
    
    
                 /*--------------- */   Player.ShowPlayerCount();  /*--------------- */ 

 
   
    }


}
