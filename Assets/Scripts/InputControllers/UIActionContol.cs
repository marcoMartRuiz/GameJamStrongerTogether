using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIActionContol : MonoBehaviour
{
    @PlayerInputMap playerInputMap;
    [SerializeField] private UIData uiData;

    private void Start()
    {
        var uiCanvasComponent = gameObject.AddComponent<Canvas>();
        // gameObject.transform.getChild(0).AddComponent<Image>();
    
        
        uiCanvasComponent.renderMode = RenderMode.ScreenSpaceOverlay;
        // gameObject.Equals(new GameObject());        
        
        // uiBackgroundImage.color = Color.blue;
    }
    // private void Awake()
    // {
    //     playerInputMap = new PlayerInputMap();

    //     playerInputMap.UI.MouseClick.performed += x => OnMouseClick(x);
    //     playerInputMap.UI.MouseHover.performed += xyValues => OnMouseHover(xyValues);
    // }
    // public void OnMouseClick(InputAction.CallbackContext context)
    // {
    //     Debug.Log("Clicked");
    // }

    // public void OnMouseHover(InputAction.CallbackContext context)
    // {

    //     Debug.Log(context);

    // }



    // void OnEnable()
    // {
    //     playerInputMap.Enable();
    // }
    // void OnDisable()
    // {
    //     playerInputMap.Disable();
    // }


}
