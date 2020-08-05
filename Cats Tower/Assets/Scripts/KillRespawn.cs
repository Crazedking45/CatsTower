using System.Collections;
using UnityEngine;

public class KillRespawn : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider Other)
    {
        player.transform.position = respawnPoint.transform.position;
    }
}
