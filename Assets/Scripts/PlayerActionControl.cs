using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerActionControl : MonoBehaviour
{
    @PlayerInputMap playerInputMap;
    Vector2 movementInput;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }
    private void Awake()
    {
        playerInputMap = new PlayerInputMap();

        playerInputMap.WorldMovement.Move.performed += x => OnMove(x); 
    }
    void OnEnable() 
    {
        playerInputMap.Enable();
    }
    void OnDisable() 
    {
        playerInputMap.Disable();
    }
    

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        rb.velocity = new Vector3(movementInput.x * 4f / 0.02f * Time.deltaTime, rb.velocity.y,movementInput.y * 4f/ 0.02f * Time.deltaTime); 
       
    }
}
