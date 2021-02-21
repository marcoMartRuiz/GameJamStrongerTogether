using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Testing : MonoBehaviour
{
   GameObject uiCanvasObj;
   bool isUICanvas;
    private void Start() {
        
        isUICanvas = false;
    }
    @PlayerInputMap playerInputMap; 
    private void Awake() 
    {
        playerInputMap = new PlayerInputMap();
        playerInputMap.WorldUI.OpenSettings.performed += input => OnEsc(input);
    }
    
     void OnEnable()
    {
        playerInputMap.Enable();
    }
    void OnDisable()
    {
        playerInputMap.Disable();
    }
    public void OnEsc(InputAction.CallbackContext context)
    {
        
        Debug.Log("escape");
    }

}
