using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
public class PlayerActionControl : MonoBehaviour
{
    @PlayerInputMap playerInputMap;
    Vector3 movementInput;
    Rigidbody rb;
    SpriteRenderer playerSpriteRender;
    Transform plalyerTranform;
    Quaternion playerQuaternion;
    GameObject VcmObj1;
    // GameObject VcmObj2; 
    // CinemachineComponentBase componentBaseBody;
    // CinemachineComponentBase componentBaseAim;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerSpriteRender = this.GetComponentInChildren<SpriteRenderer>();
        plalyerTranform = GetComponent<Transform>();

        VcmObj1 = GameObject.Find("CM vcam1");
        // GameObject VcmObj2 = GameObject.Find("CM vcam2");
        
        // CinemachineComponentBase componentBaseBody = VcmObj.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent(CinemachineCore.Stage.Body);
        
        // CinemachineComponentBase componentBaseAim = VcmObj.GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent(CinemachineCore.Stage.Aim);


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

    // private void Update() {
    //     // plalyerTranform.rotation = playerQuaternion;
    // }
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        // float LRAverage = movementInput.x + movementInput.y;
        rb.velocity = new Vector3(movementInput.x / 0.035f * Time.deltaTime, 0, movementInput.y / 0.035f * Time.deltaTime);

        // if (movementInput.x > 0f)
        // {
        //     // VcmObj1.SetActive(true);
        //     // VcmObj2.SetActive(false);
        //     playerSpriteRender.flipX = true;
        // }
        // else 
        // {
        //     //  VcmObj1.SetActive(false);
        //     // VcmObj2.SetActive(true);
        //     playerSpriteRender.flipX = false;
        // }
        // if (rb.velocity.z > 0f)
        // {
        //     VcmObj1.SetActive(false);
        //     // VcmObj2.SetActive(true);
        //     playerQuaternion.eulerAngles = new Vector3(0, 90f,0);
        // }else 
        // {
        //     VcmObj1.SetActive(true);
        //     // VcmObj2.SetActive(false);
        //     playerQuaternion.eulerAngles = new Vector3(0,0,0);
        // }

        //     if (componentBaseBody is Cinemachine3rdPersonFollow)
        // {
        //     (componentBaseBody as Cinemachine3rdPersonFollow).ShoulderOffset.x = 1f;
        //     (componentBaseAim as CinemachineComposer).m_ScreenX = .7f;
        //     (componentBaseBody as Cinemachine3rdPersonFollow).ShoulderOffset.x += .5f; 
        //     (componentBaseAim as CinemachineComposer).m_ScreenX += .2f; 

        // }

    }
}

//Rotate sprite : rotate on y obj for sprite when up or down keys
//rotate camera