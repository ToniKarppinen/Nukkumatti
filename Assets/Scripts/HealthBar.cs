using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{

    private Image healthBar;

    public float currentHealth;

    private float maxHealth = 10f;
    [SerializeField]
    private float reduceSpeed = 2f;

    private float target = 1f;

    PlayerHealth player;
    // Start is called before the first frame update
    void Start()
    {
        //Find
        healthBar= GetComponent<Image>();
        player = FindObjectOfType<PlayerHealth>();
        currentHealth = player.health;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = player.health;
        target = currentHealth / maxHealth;

        healthBar.fillAmount = Mathf.MoveTowards(healthBar.fillAmount, target, reduceSpeed * Time.deltaTime);
    }
}
