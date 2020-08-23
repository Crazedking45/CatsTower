using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTwo : MonoBehaviour
{
    public GameObject hiddenBlockRoom;

    void Start()
    {
        hiddenBlockRoom.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            hiddenBlockRoom.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            hiddenBlockRoom.gameObject.SetActive(false);
        }
    }
}
