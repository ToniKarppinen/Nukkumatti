using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{

    public CollectibleManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<CollectibleManager>();
        manager.CollectibleCount = 0;
        manager.collectibleText.text = manager.CollectibleCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
