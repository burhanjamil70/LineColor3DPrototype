using UnityEngine;

public class FixCameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    float time = 0;

    private void Start()
    {
        time = 0;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //smoothedPosition.x = transform.position.x; // Keep camera's x position unchanged
        //smoothedPosition.y = transform.position.y; // Keep camera's y position unchanged
        transform.position = smoothedPosition;
    }
}
