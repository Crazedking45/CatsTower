using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform dogTarget;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    void LateUpdate()
    {
     
        transform.position = dogTarget.position + offset;

       
    }
}
