using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour
{
    [SerializeField] private Image customImage;
    [SerializeField] private Image buttonImage;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
        {
            customImage.enabled = true;
        }
    }
      void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("player"))
        {
            customImage.enabled = false;
        }
    }


}
