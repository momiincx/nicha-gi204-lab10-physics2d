using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 0, -10f);
    private float smoothTime = 0.2f;
    private Vector3 velocity = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
