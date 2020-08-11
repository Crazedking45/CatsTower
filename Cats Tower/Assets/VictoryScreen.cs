using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Victory");
    }
}
