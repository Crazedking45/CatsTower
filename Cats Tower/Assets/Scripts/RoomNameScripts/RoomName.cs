using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomName : MonoBehaviour
{
    public GameObject startRoom;

    void Start()
    {
        startRoom.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            startRoom.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            startRoom.gameObject.SetActive(false);
        }
    }
}
