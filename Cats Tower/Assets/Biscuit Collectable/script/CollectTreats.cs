using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTreats : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        ScoringSystem.theScore += 1;
        GameObject.Destroy(gameObject);
    }
}
