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
                },
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f603dd82-fd64-4ef5-a67c-24a02ae2f114"",
                    ""expectedControlType"": ""Vector2"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""38db2439-1d1b-4455-ae6b-cecb3c0e78f0"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""cba918a9-28d7-422c-ba7d-5281473bc195"",
            ""actions"": [
                {
                    ""name"": ""MouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""a390f327-091d-4042-8df2-67882add0b70"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseHover"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cc9a7600-074d-493a-b052-d24590069934"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aac6d6d4-1c9d-41f2-a533-a7a792e04aab"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7341518-c34d-423f-90bd-8484e4e3661b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseHover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WorldUI"",
            ""id"": ""2ec4ec57-4592-4054-b2d0-68786035d67e"",
            ""actions"": [
                {
                    ""name"": ""OpenSettings"",
                    ""type"": ""Button"",
                    ""id"": ""ebed4a11-d480-451a-91f9-ce7db6130f12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4c5e5c2a-8b66-4749-b6e8-ff711b4b5ae2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WorldMovement
        m_WorldMovement = asset.FindActionMap("WorldMovement", throwIfNotFound: true);
        m_WorldMovement_Move = m_WorldMovement.FindAction("Move", throwIfNotFound: true);
        m_WorldMovement_MouseLook = m_WorldMovement.FindAction("MouseLook", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_MouseClick = m_UI.FindAction("MouseClick", throwIfNotFound: true);
        m_UI_MouseHover = m_UI.FindAction("MouseHover", throwIfNotFound: true);
        // WorldUI
        m_WorldUI = asset.FindActionMap("WorldUI", throwIfNotFound: true);
        m_WorldUI_OpenSettings = m_WorldUI.FindAction("OpenSettings", throwIfNotFound: true);
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
    private readonly InputAction m_WorldMovement_MouseLook;
    public struct WorldMovementActions
    {
        private @PlayerInputMap m_Wrapper;
        public WorldMovementActions(@PlayerInputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_WorldMovement_Move;
        public InputAction @MouseLook => m_Wrapper.m_WorldMovement_MouseLook;
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
                @MouseLook.started -= m_Wrapper.m_WorldMovementActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_WorldMovementActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_WorldMovementActionsCallbackInterface.OnMouseLook;
            }
            m_Wrapper.m_WorldMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
            }
        }
    }
    public WorldMovementActions @WorldMovement => new WorldMovementActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_MouseClick;
    private readonly InputAction m_UI_MouseHover;
    public struct UIActions
    {
        private @PlayerInputMap m_Wrapper;
        public UIActions(@PlayerInputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseClick => m_Wrapper.m_UI_MouseClick;
        public InputAction @MouseHover => m_Wrapper.m_UI_MouseHover;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @MouseClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseClick;
                @MouseClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseClick;
                @MouseClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseClick;
                @MouseHover.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseHover;
                @MouseHover.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseHover;
                @MouseHover.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMouseHover;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseClick.started += instance.OnMouseClick;
                @MouseClick.performed += instance.OnMouseClick;
                @MouseClick.canceled += instance.OnMouseClick;
                @MouseHover.started += instance.OnMouseHover;
                @MouseHover.performed += instance.OnMouseHover;
                @MouseHover.canceled += instance.OnMouseHover;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // WorldUI
    private readonly InputActionMap m_WorldUI;
    private IWorldUIActions m_WorldUIActionsCallbackInterface;
    private readonly InputAction m_WorldUI_OpenSettings;
    public struct WorldUIActions
    {
        private @PlayerInputMap m_Wrapper;
        public WorldUIActions(@PlayerInputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenSettings => m_Wrapper.m_WorldUI_OpenSettings;
        public InputActionMap Get() { return m_Wrapper.m_WorldUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WorldUIActions set) { return set.Get(); }
        public void SetCallbacks(IWorldUIActions instance)
        {
            if (m_Wrapper.m_WorldUIActionsCallbackInterface != null)
            {
                @OpenSettings.started -= m_Wrapper.m_WorldUIActionsCallbackInterface.OnOpenSettings;
                @OpenSettings.performed -= m_Wrapper.m_WorldUIActionsCallbackInterface.OnOpenSettings;
                @OpenSettings.canceled -= m_Wrapper.m_WorldUIActionsCallbackInterface.OnOpenSettings;
            }
            m_Wrapper.m_WorldUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenSettings.started += instance.OnOpenSettings;
                @OpenSettings.performed += instance.OnOpenSettings;
                @OpenSettings.canceled += instance.OnOpenSettings;
            }
        }
    }
    public WorldUIActions @WorldUI => new WorldUIActions(this);
    public interface IWorldMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseLook(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMouseHover(InputAction.CallbackContext context);
    }
    public interface IWorldUIActions
    {
        void OnOpenSettings(InputAction.CallbackContext context);
    }
}
