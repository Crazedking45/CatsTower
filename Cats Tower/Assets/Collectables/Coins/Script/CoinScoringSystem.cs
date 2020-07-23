using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScoringSystem : MonoBehaviour
{
    public GameObject scoringSytem;
    public static int theScore;


    void Update()
    {
        scoringSytem.GetComponent<Text>().text = "Coins: " + theScore;  //updating the score
    }
}
