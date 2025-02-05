using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth PlayerHealth;

    [SerializeField]
    private AudioSource ouchEffect;

    private void Awake()
    {
       PlayerHealth = FindObjectOfType<PlayerHealth>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.TakeDamage(damage);
            ouchEffect.Play();

        }


    }
}
