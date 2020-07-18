using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform dogTarget;

    public float smoothTransition = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = dogTarget.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothTransition);
        transform.position = smoothPosition;

        transform.LookAt(dogTarget);
    }
}
