using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TinoEventManager : MonoBehaviour
{

    public GameObject pausePanel;
    public GameObject gameOverPanel;

    private bool isPaused = false;

    PlayerHealth player;

    private void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        gameOverPanel = GameObject.Find("CanvasObjects/GameOverScreen/GameOverPanel");
        pausePanel = GameObject.Find("CanvasObjects/PauseCanvas/PausePanel");
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused && player.health > 0) {

            pausePanel.SetActive(true);
            Time.timeScale = 0f;
            isPaused = true;
            gameOverPanel.SetActive(false);
        }

     else if(isPaused && Input.GetKeyDown(KeyCode.Escape) && player.health > 0)
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
            isPaused = false;
        }
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
