using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlockSpawn : MonoBehaviour
{
    public GameObject weapon;
    public AudioSource audioSource;
    public GameObject key;

    void Start()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            audioSource.Play();
        }

        if (weapon.gameObject.CompareTag("Weapon"))
        {
            this.gameObject.GetComponent<Renderer>().enabled = true;
            key.SetActive(true);
            this.GetComponent<Collider>().isTrigger = false; 
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (weapon.gameObject.CompareTag("Weapon"))
        {
            this.gameObject.GetComponent<Renderer>().enabled = true;
            key.SetActive(true);
            this.GetComponent<Collider>().isTrigger = false;
        }
    }
}
