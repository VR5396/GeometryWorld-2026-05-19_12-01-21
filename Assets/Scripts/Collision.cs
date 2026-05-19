using UnityEngine;

public class Collision : MonoBehaviour
{
    private PlayerMovement Movement;

    private void Awake()
    {
        Movement = GetComponent<PlayerMovement>();
    }
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "Obstacles")
        {
            Movement.enabled = false;
            FindFirstObjectByType<GameManager>().OnLevelFailed();
        }
    }
}
