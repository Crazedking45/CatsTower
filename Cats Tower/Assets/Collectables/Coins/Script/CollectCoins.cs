﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public AudioSource collectSound;
    public chest storeChest;
    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        CoinScoringSystem.theScore += 1;
        GameObject.Destroy(gameObject);

        storeChest.currentCoins++;
        print(storeChest.currentCoins);
    }


}

  

