using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombatKit : MonoBehaviour
{
    private int hitRange = 5;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }

    void Attack()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 origin = transform.position;


     if (Physics.Raycast(origin, forward, out hit, hitRange))
        {
            if (hit.transform.gameObject.tag == "Enemy")
            {
                hit.transform.gameObject.SendMessage("TakeDamage", 30);
            }
        }
    }
}
