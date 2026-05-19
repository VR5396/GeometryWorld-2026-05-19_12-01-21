using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 MoveInput;
    public float JumpForce;
    public float MoveForce;
    private bool IsLevelFailed = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnJump(InputAction.CallbackContext Context)
    {   
        if(Context.performed && (rb.position.y < 1f))
        {
            rb.AddForce(0f, JumpForce, 0f, ForceMode.Force);
        }
    }
    public void OnMovement(InputAction.CallbackContext Context)
    { 
        MoveInput = Context.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(MoveInput.x*MoveForce,0f,MoveInput.y*MoveForce),ForceMode.VelocityChange);
        if(rb.position.y <-0.75f && IsLevelFailed == false)
        {
            IsLevelFailed = true;
            Debug.Log("LvelFailed");
            FindFirstObjectByType<GameManager>().OnLevelFailed();
        }
    }
}
