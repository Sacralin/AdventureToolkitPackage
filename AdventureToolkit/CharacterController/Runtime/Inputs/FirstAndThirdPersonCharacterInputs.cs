//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Packages/com.2322034.adventuretoolkit/AdventureToolkit/CharacterController/Runtime/Inputs/FirstAndThirdPersonCharacterInputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @FirstAndThirdPersonCharacterInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FirstAndThirdPersonCharacterInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FirstAndThirdPersonCharacterInputs"",
    ""maps"": [
        {
            ""name"": ""CharacterControls"",
            ""id"": ""33218818-8a4c-42ca-9a17-d661033b3df6"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""2de2b8e8-4ce1-416d-aeff-d052f2df8cc7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""5ea5a92e-17a6-4d1d-aa5a-d0c6e36364c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseMovement"",
                    ""type"": ""Value"",
                    ""id"": ""c1fe9fac-0c8b-4c59-b165-009c84918a3e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""71ba5b41-f23e-4e23-86d8-322dbd0624ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseWheelButton"",
                    ""type"": ""Value"",
                    ""id"": ""57bfc7ce-8dd7-4516-b0d1-3233753626ed"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""e8838cb0-b014-4fac-9e6d-8499032e1cb8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeCamera"",
                    ""type"": ""Value"",
                    ""id"": ""f0a3b39e-cdb6-43a6-9306-746eb699383a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftMouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""1ba8878b-41b6-4d8b-bef3-c6e7650a8c0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cb56e8d0-428b-41a9-973c-1d93c122e668"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3b4396a3-ff99-4c8f-871e-60e616581f2b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5227b07f-8dc9-41cb-a68d-44b84f79cafe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0981f759-327e-434a-aa7d-53b06e06d7a5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""df44eef8-183a-4b7c-b4a8-b85f1746866f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ad176c32-2f80-4be7-93de-e9b111e10627"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a7f37590-b0ca-49d0-9271-51d0f8543931"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a8c6b74-b5b3-4d4d-894d-e5a1316c22f8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a378a507-8598-4f59-91aa-8c4d94aa6e8d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a05a915a-7ed5-44f3-b6e7-eaddde0843c0"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3818229-a168-4d0c-8a26-4baa3ef09850"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseWheelButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50e60982-3174-416e-886d-cc64cb261989"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89e4d7e7-b4cd-4c83-836f-26c8a78fbe72"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4375aedf-9c19-4625-8f8b-ddaf599f8fb4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterControls
        m_CharacterControls = asset.FindActionMap("CharacterControls", throwIfNotFound: true);
        m_CharacterControls_Walk = m_CharacterControls.FindAction("Walk", throwIfNotFound: true);
        m_CharacterControls_Run = m_CharacterControls.FindAction("Run", throwIfNotFound: true);
        m_CharacterControls_MouseMovement = m_CharacterControls.FindAction("MouseMovement", throwIfNotFound: true);
        m_CharacterControls_Jump = m_CharacterControls.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControls_MouseWheelButton = m_CharacterControls.FindAction("MouseWheelButton", throwIfNotFound: true);
        m_CharacterControls_Crouch = m_CharacterControls.FindAction("Crouch", throwIfNotFound: true);
        m_CharacterControls_ChangeCamera = m_CharacterControls.FindAction("ChangeCamera", throwIfNotFound: true);
        m_CharacterControls_LeftMouseClick = m_CharacterControls.FindAction("LeftMouseClick", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CharacterControls
    private readonly InputActionMap m_CharacterControls;
    private List<ICharacterControlsActions> m_CharacterControlsActionsCallbackInterfaces = new List<ICharacterControlsActions>();
    private readonly InputAction m_CharacterControls_Walk;
    private readonly InputAction m_CharacterControls_Run;
    private readonly InputAction m_CharacterControls_MouseMovement;
    private readonly InputAction m_CharacterControls_Jump;
    private readonly InputAction m_CharacterControls_MouseWheelButton;
    private readonly InputAction m_CharacterControls_Crouch;
    private readonly InputAction m_CharacterControls_ChangeCamera;
    private readonly InputAction m_CharacterControls_LeftMouseClick;
    public struct CharacterControlsActions
    {
        private @FirstAndThirdPersonCharacterInputs m_Wrapper;
        public CharacterControlsActions(@FirstAndThirdPersonCharacterInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_CharacterControls_Walk;
        public InputAction @Run => m_Wrapper.m_CharacterControls_Run;
        public InputAction @MouseMovement => m_Wrapper.m_CharacterControls_MouseMovement;
        public InputAction @Jump => m_Wrapper.m_CharacterControls_Jump;
        public InputAction @MouseWheelButton => m_Wrapper.m_CharacterControls_MouseWheelButton;
        public InputAction @Crouch => m_Wrapper.m_CharacterControls_Crouch;
        public InputAction @ChangeCamera => m_Wrapper.m_CharacterControls_ChangeCamera;
        public InputAction @LeftMouseClick => m_Wrapper.m_CharacterControls_LeftMouseClick;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControlsActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Add(instance);
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @MouseMovement.started += instance.OnMouseMovement;
            @MouseMovement.performed += instance.OnMouseMovement;
            @MouseMovement.canceled += instance.OnMouseMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MouseWheelButton.started += instance.OnMouseWheelButton;
            @MouseWheelButton.performed += instance.OnMouseWheelButton;
            @MouseWheelButton.canceled += instance.OnMouseWheelButton;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @ChangeCamera.started += instance.OnChangeCamera;
            @ChangeCamera.performed += instance.OnChangeCamera;
            @ChangeCamera.canceled += instance.OnChangeCamera;
            @LeftMouseClick.started += instance.OnLeftMouseClick;
            @LeftMouseClick.performed += instance.OnLeftMouseClick;
            @LeftMouseClick.canceled += instance.OnLeftMouseClick;
        }

        private void UnregisterCallbacks(ICharacterControlsActions instance)
        {
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @MouseMovement.started -= instance.OnMouseMovement;
            @MouseMovement.performed -= instance.OnMouseMovement;
            @MouseMovement.canceled -= instance.OnMouseMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MouseWheelButton.started -= instance.OnMouseWheelButton;
            @MouseWheelButton.performed -= instance.OnMouseWheelButton;
            @MouseWheelButton.canceled -= instance.OnMouseWheelButton;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @ChangeCamera.started -= instance.OnChangeCamera;
            @ChangeCamera.performed -= instance.OnChangeCamera;
            @ChangeCamera.canceled -= instance.OnChangeCamera;
            @LeftMouseClick.started -= instance.OnLeftMouseClick;
            @LeftMouseClick.performed -= instance.OnLeftMouseClick;
            @LeftMouseClick.canceled -= instance.OnLeftMouseClick;
        }

        public void RemoveCallbacks(ICharacterControlsActions instance)
        {
            if (m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterControlsActions @CharacterControls => new CharacterControlsActions(this);
    public interface ICharacterControlsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnMouseMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseWheelButton(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnChangeCamera(InputAction.CallbackContext context);
        void OnLeftMouseClick(InputAction.CallbackContext context);
    }
}
