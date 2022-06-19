// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Menu/Map_Selecton.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Map_Selecton : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Map_Selecton()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Map_Selecton"",
    ""maps"": [
        {
            ""name"": ""Map_selection"",
            ""id"": ""6032151d-1a65-47f5-b56e-344f5562aeb7"",
            ""actions"": [
                {
                    ""name"": ""MapNav"",
                    ""type"": ""Button"",
                    ""id"": ""d890c0d3-b0a4-4c6c-8f96-35b23a8e3ccf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""LevelNav"",
                    ""type"": ""Button"",
                    ""id"": ""f9c5b5c3-0bfb-41a6-a66e-73d5d4f3d928"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""LevelConfirm"",
                    ""type"": ""Button"",
                    ""id"": ""d178b5a0-afc0-40cf-b95a-c8f425040ba8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0ec20d3c-c6df-4db3-91b5-d681cc0262af"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapNav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""91b67ac4-2767-435c-ab72-15ca244f0072"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6964f11f-663c-48aa-ad56-f15361e9420a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""da690e33-fc44-4313-861b-4ca5b42b92e0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelNav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b891bd7e-31e9-4e23-94df-25e56ba22cf5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0415db6e-f53e-48b7-8eda-9deb6a846529"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d72db9d5-ce9f-46f0-a570-1f6288f860d7"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Ui"",
            ""id"": ""eb6f7603-bcc9-4122-b278-7169cb304c13"",
            ""actions"": [
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""af69e10f-c257-4a0a-bc91-3de7ff446544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""MenuNav"",
                    ""type"": ""Button"",
                    ""id"": ""6ef6e1a7-a4a6-4fbc-81b6-fa1c65167f49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""eaa4c140-ad8e-440a-be37-eba27e131a54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""MapNav"",
                    ""type"": ""Button"",
                    ""id"": ""2ab7a3aa-6de6-4389-8d64-dfe80a40d3e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""LevelNav"",
                    ""type"": ""Button"",
                    ""id"": ""94b424e1-acf8-4c59-af3c-4b739ead84e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""LevelConfirm"",
                    ""type"": ""Button"",
                    ""id"": ""d9c0976f-d9e1-4108-af47-6262f626930f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Lobby"",
                    ""type"": ""Button"",
                    ""id"": ""644d310f-7bff-4d9f-9b03-3fe7bf773e01"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f9e4e3ff-414d-4428-a6a1-409552d6336e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""403d004c-24ed-4c3b-bac0-cf567ec4f991"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f47294cb-9978-4196-966d-966f25fb09db"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lobby"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""64c83b03-15a1-4bfa-8e76-15b02cb37876"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelNav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""899e72db-21c6-4113-8b9c-93b7080bad6b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9597b48e-125e-47d7-91b3-c43d9a708027"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LevelNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""21622bd1-a8d4-4f59-be01-0cb66d11b175"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapNav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""18adc9d3-4813-45ad-ac52-94cfa62bbf8a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""730e6d25-5cdf-4854-b40f-4f255554e614"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MapNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""68306afb-2334-4c8e-b09f-24936923afa2"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1c8c91d9-158b-458b-b2f4-abe5e788b705"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""26beaa7f-9fcc-4c87-abc8-1e6b72883122"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4e2cc442-fb73-4099-ada3-d17e4944549a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Map_selection
        m_Map_selection = asset.FindActionMap("Map_selection", throwIfNotFound: true);
        m_Map_selection_MapNav = m_Map_selection.FindAction("MapNav", throwIfNotFound: true);
        m_Map_selection_LevelNav = m_Map_selection.FindAction("LevelNav", throwIfNotFound: true);
        m_Map_selection_LevelConfirm = m_Map_selection.FindAction("LevelConfirm", throwIfNotFound: true);
        // Ui
        m_Ui = asset.FindActionMap("Ui", throwIfNotFound: true);
        m_Ui_Press = m_Ui.FindAction("Press", throwIfNotFound: true);
        m_Ui_MenuNav = m_Ui.FindAction("MenuNav", throwIfNotFound: true);
        m_Ui_Confirm = m_Ui.FindAction("Confirm", throwIfNotFound: true);
        m_Ui_MapNav = m_Ui.FindAction("MapNav", throwIfNotFound: true);
        m_Ui_LevelNav = m_Ui.FindAction("LevelNav", throwIfNotFound: true);
        m_Ui_LevelConfirm = m_Ui.FindAction("LevelConfirm", throwIfNotFound: true);
        m_Ui_Lobby = m_Ui.FindAction("Lobby", throwIfNotFound: true);
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

    // Map_selection
    private readonly InputActionMap m_Map_selection;
    private IMap_selectionActions m_Map_selectionActionsCallbackInterface;
    private readonly InputAction m_Map_selection_MapNav;
    private readonly InputAction m_Map_selection_LevelNav;
    private readonly InputAction m_Map_selection_LevelConfirm;
    public struct Map_selectionActions
    {
        private @Map_Selecton m_Wrapper;
        public Map_selectionActions(@Map_Selecton wrapper) { m_Wrapper = wrapper; }
        public InputAction @MapNav => m_Wrapper.m_Map_selection_MapNav;
        public InputAction @LevelNav => m_Wrapper.m_Map_selection_LevelNav;
        public InputAction @LevelConfirm => m_Wrapper.m_Map_selection_LevelConfirm;
        public InputActionMap Get() { return m_Wrapper.m_Map_selection; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Map_selectionActions set) { return set.Get(); }
        public void SetCallbacks(IMap_selectionActions instance)
        {
            if (m_Wrapper.m_Map_selectionActionsCallbackInterface != null)
            {
                @MapNav.started -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnMapNav;
                @MapNav.performed -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnMapNav;
                @MapNav.canceled -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnMapNav;
                @LevelNav.started -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnLevelNav;
                @LevelNav.performed -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnLevelNav;
                @LevelNav.canceled -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnLevelNav;
                @LevelConfirm.started -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnLevelConfirm;
                @LevelConfirm.performed -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnLevelConfirm;
                @LevelConfirm.canceled -= m_Wrapper.m_Map_selectionActionsCallbackInterface.OnLevelConfirm;
            }
            m_Wrapper.m_Map_selectionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MapNav.started += instance.OnMapNav;
                @MapNav.performed += instance.OnMapNav;
                @MapNav.canceled += instance.OnMapNav;
                @LevelNav.started += instance.OnLevelNav;
                @LevelNav.performed += instance.OnLevelNav;
                @LevelNav.canceled += instance.OnLevelNav;
                @LevelConfirm.started += instance.OnLevelConfirm;
                @LevelConfirm.performed += instance.OnLevelConfirm;
                @LevelConfirm.canceled += instance.OnLevelConfirm;
            }
        }
    }
    public Map_selectionActions @Map_selection => new Map_selectionActions(this);

    // Ui
    private readonly InputActionMap m_Ui;
    private IUiActions m_UiActionsCallbackInterface;
    private readonly InputAction m_Ui_Press;
    private readonly InputAction m_Ui_MenuNav;
    private readonly InputAction m_Ui_Confirm;
    private readonly InputAction m_Ui_MapNav;
    private readonly InputAction m_Ui_LevelNav;
    private readonly InputAction m_Ui_LevelConfirm;
    private readonly InputAction m_Ui_Lobby;
    public struct UiActions
    {
        private @Map_Selecton m_Wrapper;
        public UiActions(@Map_Selecton wrapper) { m_Wrapper = wrapper; }
        public InputAction @Press => m_Wrapper.m_Ui_Press;
        public InputAction @MenuNav => m_Wrapper.m_Ui_MenuNav;
        public InputAction @Confirm => m_Wrapper.m_Ui_Confirm;
        public InputAction @MapNav => m_Wrapper.m_Ui_MapNav;
        public InputAction @LevelNav => m_Wrapper.m_Ui_LevelNav;
        public InputAction @LevelConfirm => m_Wrapper.m_Ui_LevelConfirm;
        public InputAction @Lobby => m_Wrapper.m_Ui_Lobby;
        public InputActionMap Get() { return m_Wrapper.m_Ui; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiActions set) { return set.Get(); }
        public void SetCallbacks(IUiActions instance)
        {
            if (m_Wrapper.m_UiActionsCallbackInterface != null)
            {
                @Press.started -= m_Wrapper.m_UiActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnPress;
                @MenuNav.started -= m_Wrapper.m_UiActionsCallbackInterface.OnMenuNav;
                @MenuNav.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnMenuNav;
                @MenuNav.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnMenuNav;
                @Confirm.started -= m_Wrapper.m_UiActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnConfirm;
                @MapNav.started -= m_Wrapper.m_UiActionsCallbackInterface.OnMapNav;
                @MapNav.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnMapNav;
                @MapNav.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnMapNav;
                @LevelNav.started -= m_Wrapper.m_UiActionsCallbackInterface.OnLevelNav;
                @LevelNav.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnLevelNav;
                @LevelNav.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnLevelNav;
                @LevelConfirm.started -= m_Wrapper.m_UiActionsCallbackInterface.OnLevelConfirm;
                @LevelConfirm.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnLevelConfirm;
                @LevelConfirm.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnLevelConfirm;
                @Lobby.started -= m_Wrapper.m_UiActionsCallbackInterface.OnLobby;
                @Lobby.performed -= m_Wrapper.m_UiActionsCallbackInterface.OnLobby;
                @Lobby.canceled -= m_Wrapper.m_UiActionsCallbackInterface.OnLobby;
            }
            m_Wrapper.m_UiActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
                @MenuNav.started += instance.OnMenuNav;
                @MenuNav.performed += instance.OnMenuNav;
                @MenuNav.canceled += instance.OnMenuNav;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @MapNav.started += instance.OnMapNav;
                @MapNav.performed += instance.OnMapNav;
                @MapNav.canceled += instance.OnMapNav;
                @LevelNav.started += instance.OnLevelNav;
                @LevelNav.performed += instance.OnLevelNav;
                @LevelNav.canceled += instance.OnLevelNav;
                @LevelConfirm.started += instance.OnLevelConfirm;
                @LevelConfirm.performed += instance.OnLevelConfirm;
                @LevelConfirm.canceled += instance.OnLevelConfirm;
                @Lobby.started += instance.OnLobby;
                @Lobby.performed += instance.OnLobby;
                @Lobby.canceled += instance.OnLobby;
            }
        }
    }
    public UiActions @Ui => new UiActions(this);
    public interface IMap_selectionActions
    {
        void OnMapNav(InputAction.CallbackContext context);
        void OnLevelNav(InputAction.CallbackContext context);
        void OnLevelConfirm(InputAction.CallbackContext context);
    }
    public interface IUiActions
    {
        void OnPress(InputAction.CallbackContext context);
        void OnMenuNav(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnMapNav(InputAction.CallbackContext context);
        void OnLevelNav(InputAction.CallbackContext context);
        void OnLevelConfirm(InputAction.CallbackContext context);
        void OnLobby(InputAction.CallbackContext context);
    }
}
