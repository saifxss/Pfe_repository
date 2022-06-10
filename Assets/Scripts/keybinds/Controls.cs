// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/keybinds/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""397f0739-ebf6-4d7b-b530-cc1d9b2c427a"",
            ""actions"": [
                {
                    ""name"": ""Mve"",
                    ""type"": ""Value"",
                    ""id"": ""63d3a09e-521b-4595-8cc4-aeca16ca863a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""18eab1c9-9ae2-47ba-bc57-085fda43dcba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""f052e524-6eb0-4c74-a855-7750a11c5a8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Action 1"",
                    ""type"": ""Value"",
                    ""id"": ""8b1a184f-6aea-4abf-8180-4f6f87338075"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Action 2"",
                    ""type"": ""Value"",
                    ""id"": ""31808d6c-16a3-45e9-9e72-12c06cc6d3c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Action 3"",
                    ""type"": ""Value"",
                    ""id"": ""d07f51b4-67d7-4ec9-a0a2-28921d84cf4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Action 4"",
                    ""type"": ""Value"",
                    ""id"": ""abb05044-2249-4e3d-8e17-760f781a22fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Mvt j"",
                    ""id"": ""14793f5a-5014-4201-b0ca-8bf74c33aac7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""725308b3-0906-4e19-bdd1-0dd007e9ac08"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""36bdae5e-3c98-484f-87fe-15fbf7b02050"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Mvt k"",
                    ""id"": ""91b89c63-e684-454b-b4f5-0eb58fd6c14e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""73ccd90a-9e0f-42ee-a2f3-7134c19cf642"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d0a58cd0-9172-4c3c-ac48-10da1439b189"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Joy Mvt"",
                    ""id"": ""f4c6c746-fe87-42c6-88cd-c6a80296221b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8c38a1f1-cb1b-4a5c-a670-426cd6fe8336"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""85d0932a-aa70-49d8-ab15-a669e046a41a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mve"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9459c3c6-c892-4632-b91b-cd8a81aaf28f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb18533c-dbc5-4f57-ad5c-eb2557f477d4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de5cd1bb-24de-4d10-9335-7818401df28a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""219093d7-308a-4f89-8b4b-8af49cee0f3f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be7f6c2a-3659-41c1-a3f2-23018721fe0f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41d70827-d33f-4e25-8a74-ecfe495e1813"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""248da106-72ba-4a55-848e-42267223db71"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8afe6c76-bdda-47cd-bdc6-6c65266b9c74"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""761f57e1-4ffb-4c00-83e4-365bb1b1c623"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45cdcaa2-3ac3-4ff6-9ec4-a553e40763fa"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0d31734-4c4f-4e97-8eca-9517bf171507"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""669c966b-ee22-47f4-a48c-bbf3f914b11d"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Mve = m_Player.FindAction("Mve", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_Action1 = m_Player.FindAction("Action 1", throwIfNotFound: true);
        m_Player_Action2 = m_Player.FindAction("Action 2", throwIfNotFound: true);
        m_Player_Action3 = m_Player.FindAction("Action 3", throwIfNotFound: true);
        m_Player_Action4 = m_Player.FindAction("Action 4", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Mve;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_Action1;
    private readonly InputAction m_Player_Action2;
    private readonly InputAction m_Player_Action3;
    private readonly InputAction m_Player_Action4;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mve => m_Wrapper.m_Player_Mve;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @Action1 => m_Wrapper.m_Player_Action1;
        public InputAction @Action2 => m_Wrapper.m_Player_Action2;
        public InputAction @Action3 => m_Wrapper.m_Player_Action3;
        public InputAction @Action4 => m_Wrapper.m_Player_Action4;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Mve.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMve;
                @Mve.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMve;
                @Mve.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMve;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Action1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction1;
                @Action1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction1;
                @Action1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction1;
                @Action2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction2;
                @Action2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction2;
                @Action2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction2;
                @Action3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction3;
                @Action3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction3;
                @Action3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction3;
                @Action4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction4;
                @Action4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction4;
                @Action4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction4;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mve.started += instance.OnMve;
                @Mve.performed += instance.OnMve;
                @Mve.canceled += instance.OnMve;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Action1.started += instance.OnAction1;
                @Action1.performed += instance.OnAction1;
                @Action1.canceled += instance.OnAction1;
                @Action2.started += instance.OnAction2;
                @Action2.performed += instance.OnAction2;
                @Action2.canceled += instance.OnAction2;
                @Action3.started += instance.OnAction3;
                @Action3.performed += instance.OnAction3;
                @Action3.canceled += instance.OnAction3;
                @Action4.started += instance.OnAction4;
                @Action4.performed += instance.OnAction4;
                @Action4.canceled += instance.OnAction4;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMve(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnAction1(InputAction.CallbackContext context);
        void OnAction2(InputAction.CallbackContext context);
        void OnAction3(InputAction.CallbackContext context);
        void OnAction4(InputAction.CallbackContext context);
    }
}
