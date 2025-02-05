using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollectible : MonoBehaviour
{
    public CollectibleManager cm;

    [SerializeField] private AudioSource collectionsoundEffect;

    private void Start()
    {
        cm = FindObjectOfType<CollectibleManager>();
        cm.CollectibleCount = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.CompareTag("Collectible"))
      {
        collectionsoundEffect.Play();
        cm.CollectibleCount++;
        Destroy(other.gameObject);
        Debug.Log(cm.CollectibleCount);
        cm.collectibleText.text = cm.CollectibleCount.ToString();
      }

    }
    
}
