using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    public bool inTrigger;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;

    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DoorScript.doorKey = true;
            Destroy(this.gameObject);
        }
    }
    void OnGUI()
    {
        if (inTrigger)
        {

            GUI.Box(new Rect(600, 300, 200, 50), "Press F to take Key");
        }

    }
}
