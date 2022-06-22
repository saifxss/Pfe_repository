// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Custom_Map/Custom_Map_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Custom_Map_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Custom_Map_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Custom_Map_Controls"",
    ""maps"": [
        {
            ""name"": ""Custom_Map"",
            ""id"": ""ec718950-cf22-480d-a054-4bafd9bfcb2c"",
            ""actions"": [
                {
                    ""name"": ""Items"",
                    ""type"": ""Button"",
                    ""id"": ""39619b68-f421-43bf-977a-de083eb23e02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""ListNav_hor"",
                    ""type"": ""Button"",
                    ""id"": ""3b732c42-a354-448e-b998-e4616921fc8b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""ListNav_ver"",
                    ""type"": ""Button"",
                    ""id"": ""d7b4d5dd-8d16-408f-95fb-d7ce192038ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Item_Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""b4e92546-041e-4daa-8971-16f1a0ae030a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Item_delete"",
                    ""type"": ""Button"",
                    ""id"": ""1e0395ec-dd08-40d3-9b06-9b494f70159f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Bpm_Change"",
                    ""type"": ""Button"",
                    ""id"": ""91bc2954-310a-487e-8925-541f925d531b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Bmp_Nav"",
                    ""type"": ""Button"",
                    ""id"": ""7b2b4555-25fe-4f33-bb29-7e572fed713f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""3d9dc486-4fa8-4ecd-97ce-ba9b3545cf0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Load"",
                    ""type"": ""Button"",
                    ""id"": ""5bbc12ca-47ca-4b1a-b487-e2fe2e763291"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Button"",
                    ""id"": ""bd97d697-addf-45e0-9715-06eac39dba20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""BackToMenu"",
                    ""type"": ""Button"",
                    ""id"": ""7b29f88f-1cfc-481c-b992-2a472b46cf76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b122e2f5-2d4d-4155-adaa-1a44f29db1dd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Items"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""713ac4b4-e181-479f-acb0-bd7dafa69d9d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Items"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b5f6033e-ffa2-4862-9a0d-a56568bc295a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Items"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b699f02c-4d49-4c73-bac0-faa851b29161"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ListNav_hor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""01fbbd37-0488-4d62-b9b1-901e479cdbd2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ListNav_hor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6db5e806-2705-48a4-9459-6a92f2972b71"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ListNav_hor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d35313ba-f56b-4d5f-bda8-39cde70b0528"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ListNav_ver"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bc8d2ccf-6a63-40db-951a-5e22369bd01a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ListNav_ver"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""903a0f67-9a7e-4091-9a59-9d2a3e0147c4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ListNav_ver"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2f39d90f-f5e9-4421-9aaf-c076897364f1"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item_Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94572ce8-de38-4fc5-be56-10f26b37dd37"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item_delete"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15d9d63b-cf07-442f-a7a4-e3f1610e3c14"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bpm_Change"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""93aab448-d4ba-4291-b1ab-506c750ede4c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bmp_Nav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""80633a89-fb39-4d02-9326-e5bcbb74931a"",
                    ""path"": ""<Keyboard>/pageUp"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bmp_Nav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f3d15ff7-dd8e-4c89-8959-ef0162b1d38c"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bmp_Nav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""93ac6da8-778f-4cd5-8a5f-47788a1d9dd2"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9815604-8e9d-4454-b265-ff42a712306c"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Load"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""76720c27-07f1-4ee3-ae02-f6a332ec2507"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8c8787e2-85ed-4ed1-905e-a56c80537c5a"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""38b963aa-8c33-4527-9639-bc5b342aed56"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""547e91a6-0ad0-400e-bb8d-3c4a97a1a152"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Custom_Map
        m_Custom_Map = asset.FindActionMap("Custom_Map", throwIfNotFound: true);
        m_Custom_Map_Items = m_Custom_Map.FindAction("Items", throwIfNotFound: true);
        m_Custom_Map_ListNav_hor = m_Custom_Map.FindAction("ListNav_hor", throwIfNotFound: true);
        m_Custom_Map_ListNav_ver = m_Custom_Map.FindAction("ListNav_ver", throwIfNotFound: true);
        m_Custom_Map_Item_Confirm = m_Custom_Map.FindAction("Item_Confirm", throwIfNotFound: true);
        m_Custom_Map_Item_delete = m_Custom_Map.FindAction("Item_delete", throwIfNotFound: true);
        m_Custom_Map_Bpm_Change = m_Custom_Map.FindAction("Bpm_Change", throwIfNotFound: true);
        m_Custom_Map_Bmp_Nav = m_Custom_Map.FindAction("Bmp_Nav", throwIfNotFound: true);
        m_Custom_Map_Save = m_Custom_Map.FindAction("Save", throwIfNotFound: true);
        m_Custom_Map_Load = m_Custom_Map.FindAction("Load", throwIfNotFound: true);
        m_Custom_Map_Scroll = m_Custom_Map.FindAction("Scroll", throwIfNotFound: true);
        m_Custom_Map_BackToMenu = m_Custom_Map.FindAction("BackToMenu", throwIfNotFound: true);
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

    // Custom_Map
    private readonly InputActionMap m_Custom_Map;
    private ICustom_MapActions m_Custom_MapActionsCallbackInterface;
    private readonly InputAction m_Custom_Map_Items;
    private readonly InputAction m_Custom_Map_ListNav_hor;
    private readonly InputAction m_Custom_Map_ListNav_ver;
    private readonly InputAction m_Custom_Map_Item_Confirm;
    private readonly InputAction m_Custom_Map_Item_delete;
    private readonly InputAction m_Custom_Map_Bpm_Change;
    private readonly InputAction m_Custom_Map_Bmp_Nav;
    private readonly InputAction m_Custom_Map_Save;
    private readonly InputAction m_Custom_Map_Load;
    private readonly InputAction m_Custom_Map_Scroll;
    private readonly InputAction m_Custom_Map_BackToMenu;
    public struct Custom_MapActions
    {
        private @Custom_Map_Controls m_Wrapper;
        public Custom_MapActions(@Custom_Map_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Items => m_Wrapper.m_Custom_Map_Items;
        public InputAction @ListNav_hor => m_Wrapper.m_Custom_Map_ListNav_hor;
        public InputAction @ListNav_ver => m_Wrapper.m_Custom_Map_ListNav_ver;
        public InputAction @Item_Confirm => m_Wrapper.m_Custom_Map_Item_Confirm;
        public InputAction @Item_delete => m_Wrapper.m_Custom_Map_Item_delete;
        public InputAction @Bpm_Change => m_Wrapper.m_Custom_Map_Bpm_Change;
        public InputAction @Bmp_Nav => m_Wrapper.m_Custom_Map_Bmp_Nav;
        public InputAction @Save => m_Wrapper.m_Custom_Map_Save;
        public InputAction @Load => m_Wrapper.m_Custom_Map_Load;
        public InputAction @Scroll => m_Wrapper.m_Custom_Map_Scroll;
        public InputAction @BackToMenu => m_Wrapper.m_Custom_Map_BackToMenu;
        public InputActionMap Get() { return m_Wrapper.m_Custom_Map; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Custom_MapActions set) { return set.Get(); }
        public void SetCallbacks(ICustom_MapActions instance)
        {
            if (m_Wrapper.m_Custom_MapActionsCallbackInterface != null)
            {
                @Items.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItems;
                @Items.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItems;
                @Items.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItems;
                @ListNav_hor.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnListNav_hor;
                @ListNav_hor.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnListNav_hor;
                @ListNav_hor.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnListNav_hor;
                @ListNav_ver.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnListNav_ver;
                @ListNav_ver.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnListNav_ver;
                @ListNav_ver.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnListNav_ver;
                @Item_Confirm.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItem_Confirm;
                @Item_Confirm.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItem_Confirm;
                @Item_Confirm.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItem_Confirm;
                @Item_delete.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItem_delete;
                @Item_delete.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItem_delete;
                @Item_delete.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnItem_delete;
                @Bpm_Change.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBpm_Change;
                @Bpm_Change.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBpm_Change;
                @Bpm_Change.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBpm_Change;
                @Bmp_Nav.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBmp_Nav;
                @Bmp_Nav.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBmp_Nav;
                @Bmp_Nav.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBmp_Nav;
                @Save.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnSave;
                @Load.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnLoad;
                @Load.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnLoad;
                @Load.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnLoad;
                @Scroll.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnScroll;
                @BackToMenu.started -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBackToMenu;
                @BackToMenu.performed -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBackToMenu;
                @BackToMenu.canceled -= m_Wrapper.m_Custom_MapActionsCallbackInterface.OnBackToMenu;
            }
            m_Wrapper.m_Custom_MapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Items.started += instance.OnItems;
                @Items.performed += instance.OnItems;
                @Items.canceled += instance.OnItems;
                @ListNav_hor.started += instance.OnListNav_hor;
                @ListNav_hor.performed += instance.OnListNav_hor;
                @ListNav_hor.canceled += instance.OnListNav_hor;
                @ListNav_ver.started += instance.OnListNav_ver;
                @ListNav_ver.performed += instance.OnListNav_ver;
                @ListNav_ver.canceled += instance.OnListNav_ver;
                @Item_Confirm.started += instance.OnItem_Confirm;
                @Item_Confirm.performed += instance.OnItem_Confirm;
                @Item_Confirm.canceled += instance.OnItem_Confirm;
                @Item_delete.started += instance.OnItem_delete;
                @Item_delete.performed += instance.OnItem_delete;
                @Item_delete.canceled += instance.OnItem_delete;
                @Bpm_Change.started += instance.OnBpm_Change;
                @Bpm_Change.performed += instance.OnBpm_Change;
                @Bpm_Change.canceled += instance.OnBpm_Change;
                @Bmp_Nav.started += instance.OnBmp_Nav;
                @Bmp_Nav.performed += instance.OnBmp_Nav;
                @Bmp_Nav.canceled += instance.OnBmp_Nav;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
                @Load.started += instance.OnLoad;
                @Load.performed += instance.OnLoad;
                @Load.canceled += instance.OnLoad;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @BackToMenu.started += instance.OnBackToMenu;
                @BackToMenu.performed += instance.OnBackToMenu;
                @BackToMenu.canceled += instance.OnBackToMenu;
            }
        }
    }
    public Custom_MapActions @Custom_Map => new Custom_MapActions(this);
    public interface ICustom_MapActions
    {
        void OnItems(InputAction.CallbackContext context);
        void OnListNav_hor(InputAction.CallbackContext context);
        void OnListNav_ver(InputAction.CallbackContext context);
        void OnItem_Confirm(InputAction.CallbackContext context);
        void OnItem_delete(InputAction.CallbackContext context);
        void OnBpm_Change(InputAction.CallbackContext context);
        void OnBmp_Nav(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
        void OnLoad(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnBackToMenu(InputAction.CallbackContext context);
    }
}
