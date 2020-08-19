using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }
   
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");
        //healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + " died.");
    }
}
