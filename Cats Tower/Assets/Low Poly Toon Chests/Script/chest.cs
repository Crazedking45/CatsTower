using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public Animator anima;
    private bool trigger;
    public Transform playerPosition;

    public Transform bone;
    public Transform coin;

    private int storeCoins = 1;
    public int currentCoins;
    private bool Full = false;

    public Collider storeTrig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F) && trigger == true && Full == false)
        {
            anima.SetBool("open", true);
            storeCoins = SpawnObject();

            Destroy(storeTrig);
            trigger = false;
        }

        if(Vector3.Distance(playerPosition.position, transform.position) >= 5f || currentCoins == storeCoins)
        {
            Full = false;
            anima.SetBool("open", false);
        }

        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            trigger = true;
        }
        
    }
    int SpawnObject()
    {
    
        int storeNumber = Random.Range(1, 4);
        for(int i = 0; i < storeNumber; i++)
        {
            int randObjects = Random.Range(0, 2);
            if(randObjects == 0)
            {
                Instantiate(coin, new Vector3(transform.position.x, transform.position.y, transform.position.z + (i + 1)), Quaternion.identity);
                
            }
            else

                Instantiate(bone, new Vector3(transform.position.x, transform.position.y, transform.position.z + (i + 1)) , Quaternion.identity);

        }
        print(storeNumber);
        return storeNumber;

        
    }
}
