using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    private int count;
    public GameObject TriggerObj;
    
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        TriggerObj.gameObject.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        if(count == 20)
        {
            TriggerObj.gameObject.SetActive(false);
        }
    }
}
