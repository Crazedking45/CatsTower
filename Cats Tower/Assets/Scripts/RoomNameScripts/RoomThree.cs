using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomThree : MonoBehaviour
{
    public GameObject logRoom;

    void Start()
    {
        logRoom.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            logRoom.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            logRoom.gameObject.SetActive(false);
        }
    }
}
