using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed = 3f;

    private Vector3 start;
    private Vector3 currentTarget;

    void Start()
    {
        start = transform.position;
        currentTarget = targetPosition;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        if (transform.position == currentTarget)
        {
            currentTarget = currentTarget == start ? targetPosition : start;
        }
    }
}