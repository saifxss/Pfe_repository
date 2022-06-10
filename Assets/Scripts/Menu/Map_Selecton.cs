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
        }
    ],
    ""controlSchemes"": []
}");
        // Map_selection
        m_Map_selection = asset.FindActionMap("Map_selection", throwIfNotFound: true);
        m_Map_selection_MapNav = m_Map_selection.FindAction("MapNav", throwIfNotFound: true);
        m_Map_selection_LevelNav = m_Map_selection.FindAction("LevelNav", throwIfNotFound: true);
        m_Map_selection_LevelConfirm = m_Map_selection.FindAction("LevelConfirm", throwIfNotFound: true);
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
    public interface IMap_selectionActions
    {
        void OnMapNav(InputAction.CallbackContext context);
        void OnLevelNav(InputAction.CallbackContext context);
        void OnLevelConfirm(InputAction.CallbackContext context);
    }
}
