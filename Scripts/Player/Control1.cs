// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/Control1.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Control1 : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Control1()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control1"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""7dba353e-2c04-41d9-a8f0-299b2d5db72c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""3099c38a-632a-40ff-8462-2c22a0f6876b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grenade"",
                    ""type"": ""Button"",
                    ""id"": ""635ffc63-f193-4580-9530-453093f7d2b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f2171991-826a-47bb-a101-68dde5ea4325"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8217e2f0-bf3c-4a37-94d7-4cc4cd3bd8f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""23feed77-304d-4774-8e87-89cc8a1d4f3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""8499f4a7-a1e8-4d77-a224-98c490bc64d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""107d43d0-5d2d-4613-8b01-9ee3d16be10f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9551ea42-1a26-42d5-8fa8-4160b0cef885"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grenade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a8755d-bdb3-4474-97df-59b32dd0f0e0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6bf318a-0a4d-4331-8182-7605fa4f9a04"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47aa40c2-2c4e-41b0-86df-9969ea5949d1"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d2a4f7e-5885-4cd7-aaf7-ecd37e6e52bb"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b5a470d-fb37-4d1e-94ee-9cffc4f64d1a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83262f29-3fd8-4409-b0b7-75bbbded7468"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerController
        m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
        m_PlayerController_Move = m_PlayerController.FindAction("Move", throwIfNotFound: true);
        m_PlayerController_Grenade = m_PlayerController.FindAction("Grenade", throwIfNotFound: true);
        m_PlayerController_Look = m_PlayerController.FindAction("Look", throwIfNotFound: true);
        m_PlayerController_Jump = m_PlayerController.FindAction("Jump", throwIfNotFound: true);
        m_PlayerController_Pause = m_PlayerController.FindAction("Pause", throwIfNotFound: true);
        m_PlayerController_Cancel = m_PlayerController.FindAction("Cancel", throwIfNotFound: true);
        m_PlayerController_Confirm = m_PlayerController.FindAction("Confirm", throwIfNotFound: true);
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

    // PlayerController
    private readonly InputActionMap m_PlayerController;
    private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
    private readonly InputAction m_PlayerController_Move;
    private readonly InputAction m_PlayerController_Grenade;
    private readonly InputAction m_PlayerController_Look;
    private readonly InputAction m_PlayerController_Jump;
    private readonly InputAction m_PlayerController_Pause;
    private readonly InputAction m_PlayerController_Cancel;
    private readonly InputAction m_PlayerController_Confirm;
    public struct PlayerControllerActions
    {
        private @Control1 m_Wrapper;
        public PlayerControllerActions(@Control1 wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerController_Move;
        public InputAction @Grenade => m_Wrapper.m_PlayerController_Grenade;
        public InputAction @Look => m_Wrapper.m_PlayerController_Look;
        public InputAction @Jump => m_Wrapper.m_PlayerController_Jump;
        public InputAction @Pause => m_Wrapper.m_PlayerController_Pause;
        public InputAction @Cancel => m_Wrapper.m_PlayerController_Cancel;
        public InputAction @Confirm => m_Wrapper.m_PlayerController_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnMove;
                @Grenade.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnGrenade;
                @Grenade.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnGrenade;
                @Grenade.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnGrenade;
                @Look.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Pause.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPause;
                @Cancel.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCancel;
                @Confirm.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnConfirm;
            }
            m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Grenade.started += instance.OnGrenade;
                @Grenade.performed += instance.OnGrenade;
                @Grenade.canceled += instance.OnGrenade;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
            }
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    public interface IPlayerControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnGrenade(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
}
