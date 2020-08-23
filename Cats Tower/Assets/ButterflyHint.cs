using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyHint : MonoBehaviour
{
    public GameObject HintText;

    void Start()
    {
        HintText.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            HintText.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            HintText.gameObject.SetActive(false);
        }
    }
}
