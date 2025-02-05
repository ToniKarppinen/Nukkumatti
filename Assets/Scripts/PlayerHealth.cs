using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int health;

    [Tooltip("Vedä tähän slottiin Gameover Canvas objektin sisältä child: Panel")]
    public GameObject gameOverPanel;
    
    void Start()
    {
        gameOverPanel = GameObject.Find("/CanvasObjects/GameOverScreen/GameOverPanel");
        health = maxHealth;
        gameOverPanel.SetActive(false);
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) 
        {
            GameOver();
        }

    }

    // Display the game over screen and destroy our player
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Destroy(gameObject);
        Debug.Log("Dead");
    }
}
