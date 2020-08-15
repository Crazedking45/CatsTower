using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collect : MonoBehaviour
{
    public Text countText;
    public Text DoorOpenText;
    private int count;
    public Text collectItem;
    public GameObject TriggerObj;
    public GameObject uiObject;
    public GameObject TextTrigger;
    public GameObject DoorUnlockedText;

    public float timer = 3;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        DoorOpenText.text = "";
        SetCountText();
        collectItem.gameObject.SetActive(true);
        TriggerObj.gameObject.SetActive(true);
        uiObject.SetActive(false);
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
        countText.text = "Coint: " + countText.ToString();
        if(count == 20)
        {
            DoorOpenText.text = "Door Unlocked!";
            collectItem.gameObject.SetActive(false);
            TriggerObj.gameObject.SetActive(false);
            count = count - 20;
            countText.text = "Coint: " + countText.ToString();
            TextTrigger.gameObject.SetActive(false);

            Destroy(DoorUnlockedText, timer);
        }
    }
}
