using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject playerSpawner;
    public GameObject playerPrefab;
    // Start is called before the first frame update

    private void Awake()
    {
        playerPrefab = GameObject.FindWithTag("Player");
        playerPrefab.transform.position = playerSpawner.transform.position;
        playerSpawner = GameObject.FindWithTag("PlayerSpawner");
    }
    void Start()
    {
      //  Instantiate(playerPrefab, playerSpawner.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
