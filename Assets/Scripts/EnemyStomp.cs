using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour
{
    [SerializeField]
    private AudioSource enemyDeathSource;
    


    private bool isPlaying = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "WeakPoint")
        {
            
            Destroy(collision.gameObject);
            

        }

    }

  


}
