using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject Green;
    public GameObject Red;

    public HealthBarSys healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        Green.gameObject.SetActive(true);
        Red.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Virus"))
        {
            TakeDamage(20);
            Red.gameObject.SetActive(false);
            Green.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("VirusBound"))
        {
            Red.gameObject.SetActive(true);
            Green.gameObject.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("VirusBound"))
        {
            Red.gameObject.SetActive(false);
            Green.gameObject.SetActive(true);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
