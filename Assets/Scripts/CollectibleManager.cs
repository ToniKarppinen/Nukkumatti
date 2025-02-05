using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectibleManager : MonoBehaviour
{
    public int CollectibleCount;
    public TextMeshProUGUI collectibleText;
    public GameObject collectibles;

  
    public void Start()
    {
        collectibles = GameObject.Find("CanvasObjects/GameUI/CollectibleCount");
        collectibleText = collectibles.GetComponent<TextMeshProUGUI>();
        CollectibleCount = 0;
        collectibleText.text = "0";
    }


}
