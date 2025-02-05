using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Next level");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            DontDestroyOnLoad(collision.gameObject);
        }
    }
}
