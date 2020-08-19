using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlockSpawn : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject key;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            audioSource.Play();
        }

        else
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            key.SetActive(false);
        }

        if (other.gameObject.CompareTag("Weapon"))
        {
            this.gameObject.GetComponent<Renderer>().enabled = true;
            key.SetActive(true);
        }

        else
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            key.SetActive(false);
        }
    }
}
