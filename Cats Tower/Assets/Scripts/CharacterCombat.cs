using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]

public class CharacterCombat : MonoBehaviour
{
    CharacterStats myStats;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    
    void Start()
    {
        myStats = GetComponent<CharacterStats>();

    }
    
   public void Attack (CharacterStats targetStats)
    {
        targetStats.TakeDamage(myStats.damage.GetValue());

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange,enemyLayers);

        foreach(Collider enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
        }
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack(myStats);
        }
    }
    void onDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
