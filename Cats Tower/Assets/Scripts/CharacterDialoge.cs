using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDialoge : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false); 
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(6);

        Destroy(uiObject);
        Destroy(gameObject);
    }

}
