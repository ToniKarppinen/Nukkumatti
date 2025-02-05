using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    //Make a variable for the PlayerHealth - Script
    public PlayerHealth playerHealthScript;

    private void Start()
    {

        // Get reference to the Player Health script and assign it to this variable
        playerHealthScript = FindObjectOfType<PlayerHealth>();
    }


    //If player hits the Trap, player health = 0 and run Game over logic.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Trap")
        {
            playerHealthScript.health = 0;
            playerHealthScript.GameOver();
        }
    }
}
