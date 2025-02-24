﻿using System.Security.Cryptography;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealth { get; private set; }
    public Stat damage;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
   
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }
    public virtual void Die()
    {
        Debug.Log(transform.name + " died");
       // Destroy(gameObject);
    }
}
