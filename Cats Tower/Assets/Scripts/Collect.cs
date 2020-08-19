using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collect : MonoBehaviour
{
    public Text countText;
    public Text keyCountText;
    public Text DoorOpenText;
    private int count;
    private int keyCount;
    public Text collectItem;
    public GameObject TriggerObj;
    public GameObject uiObject;
    public GameObject TextTrigger;
    public GameObject DoorUnlockedText;

    public GameObject DoorVanish;

    public float timer = 3;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        keyCount = 0;
        DoorOpenText.text = "";
        SetCountText();
        SetKeyCountText();
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

        if (other.gameObject.CompareTag("key"))
        {
            other.gameObject.SetActive(false);
            keyCount = keyCount + 1;
            SetKeyCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Coin: " + countText.ToString();

        if (count == 20)
        {
            DoorOpenText.text = "Door Unlocked!";
            collectItem.gameObject.SetActive(false);
            TriggerObj.gameObject.SetActive(false);
            count = count - 20;
            countText.text = "Coin: " + countText.ToString();
            TextTrigger.gameObject.SetActive(false);

            Destroy(DoorUnlockedText, timer);
        }
    }

    void SetKeyCountText()
    {
        if (keyCount >= 1)
        {
            DoorVanish.SetActive(false);

        }
    }
}