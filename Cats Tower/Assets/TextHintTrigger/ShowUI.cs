﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {

        uiObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");

        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);

        uiObject.SetActive(false);

        

    }
}
