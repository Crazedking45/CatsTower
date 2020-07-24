using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTreats : MonoBehaviour
{
    public AudioSource collectSound;
    public chest storeChest;
    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        ScoringSystem.theScore += 1;
        GameObject.Destroy(gameObject);

        storeChest.currentCoins++;
        print(storeChest.currentCoins);
    }
}
