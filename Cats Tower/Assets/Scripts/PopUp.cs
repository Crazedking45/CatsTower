using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public GameObject GreetText;
    public GameObject ByeText;

    void Start()
    {
        GreetText.gameObject.SetActive(false);
        ByeText.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            GreetText.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            GreetText.gameObject.SetActive(false);
            ByeText.gameObject.SetActive(true);
        }
    }
}
