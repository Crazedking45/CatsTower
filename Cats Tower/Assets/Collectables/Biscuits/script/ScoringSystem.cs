using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoringSytem;
    public static int theScore;
  

    void Update()
    {
        scoringSytem.GetComponent<Text>().text = "Good Boy Treats: " + theScore;  //updating the score
    }
}
