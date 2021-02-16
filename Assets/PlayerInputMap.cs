// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputMap"",
    ""maps"": [
        {
            ""name"": ""WorldMovement"",
            ""id"": ""16e36f62-5035-44b9-8865-dce8a03c5314"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""a4a5a689-1fd5-4dae-b244-a8a77889dcb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9fa35e29-fdd4-4e7d-bebf-1bde0f1cf7a9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4f1bf181-44b8-4862-aff4-2bc111647c6e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5d715805-47d7-4cbd-a1d2-bfe6912f5833"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d453cd72-a6b9-456a-ad39-dff35da7e77c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a8c54ecb-b4df-466d-9724-c41af085b758"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WorldMovement
        m_WorldMovement = asset.FindActionMap("WorldMovement", throwIfNotFound: true);
        m_WorldMovement_Move = m_WorldMovement.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // WorldMovement
    private readonly InputActionMap m_WorldMovement;
    private IWorldMovementActions m_WorldMovementActionsCallbackInterface;
    private readonly InputAction m_WorldMovement_Move;
    public struct WorldMovementActions
    {
        private @PlayerInputMap m_Wrapper;
        public WorldMovementActions(@PlayerInputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_WorldMovement_Move;
        public InputActionMap Get() { return m_Wrapper.m_WorldMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WorldMovementActions set) { return set.Get(); }
        public void SetCallbacks(IWorldMovementActions instance)
        {
            if (m_Wrapper.m_WorldMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_WorldMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WorldMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WorldMovementActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_WorldMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public WorldMovementActions @WorldMovement => new WorldMovementActions(this);
    public interface IWorldMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
