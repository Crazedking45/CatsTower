using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreName : MonoBehaviour
{
    public GameObject storeRoom;

    void Start()
    {
        storeRoom.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            storeRoom.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            storeRoom.gameObject.SetActive(false);
        }
    }
}
