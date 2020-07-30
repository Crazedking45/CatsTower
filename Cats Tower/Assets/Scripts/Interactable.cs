
using System;
using System.Security.Cryptography;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;

    public virtual void Interact()
    {

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
