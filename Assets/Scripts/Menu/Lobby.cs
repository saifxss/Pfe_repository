// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Menu/Lobby.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Lobby : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Lobby()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Lobby"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""20b22687-af40-400f-8aa0-96ab0deac9a7"",
            ""actions"": [
                {
                    ""name"": ""Lobby"",
                    ""type"": ""Button"",
                    ""id"": ""aef35dc5-1a70-4166-b53c-7684a3345de6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9d5b67d5-64ef-43ca-bc44-8fbaf30bac56"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lobby"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_Lobby = m_Newactionmap.FindAction("Lobby", throwIfNotFound: true);
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

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_Lobby;
    public struct NewactionmapActions
    {
        private @Lobby m_Wrapper;
        public NewactionmapActions(@Lobby wrapper) { m_Wrapper = wrapper; }
        public InputAction @Lobby => m_Wrapper.m_Newactionmap_Lobby;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @Lobby.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnLobby;
                @Lobby.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnLobby;
                @Lobby.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnLobby;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Lobby.started += instance.OnLobby;
                @Lobby.performed += instance.OnLobby;
                @Lobby.canceled += instance.OnLobby;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface INewactionmapActions
    {
        void OnLobby(InputAction.CallbackContext context);
    }
}
