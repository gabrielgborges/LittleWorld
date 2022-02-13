// GENERATED AUTOMATICALLY FROM 'Assets/_Project/ActionControllers/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Standard"",
            ""id"": ""2e19f530-75ba-4292-ae71-41b01e05f26c"",
            ""actions"": [
                {
                    ""name"": ""MoveSideWays"",
                    ""type"": ""Button"",
                    ""id"": ""2d6a3dd8-cbff-4998-9b0f-63f19f4fc3af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveHeightWays"",
                    ""type"": ""Button"",
                    ""id"": ""d81c2b8b-5e02-4ab9-ab3d-7755a1375da4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""SideWays"",
                    ""id"": ""4dcb199e-1159-4383-95f8-d4f0836136f0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSideWays"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6f69f02d-36a2-4948-b8ff-3e4e8098a186"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSideWays"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""13888f33-8b65-4b2d-9866-c59969fab830"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSideWays"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HeightWays"",
                    ""id"": ""d376aa0f-454b-42be-a138-020ec35ec41e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHeightWays"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fa8a7254-6904-4d28-b347-dc2bc94b8565"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHeightWays"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""788750b9-85cf-4da0-818b-9041ac7939e5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHeightWays"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Standard
        m_Standard = asset.FindActionMap("Standard", throwIfNotFound: true);
        m_Standard_MoveSideWays = m_Standard.FindAction("MoveSideWays", throwIfNotFound: true);
        m_Standard_MoveHeightWays = m_Standard.FindAction("MoveHeightWays", throwIfNotFound: true);
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

    // Standard
    private readonly InputActionMap m_Standard;
    private IStandardActions m_StandardActionsCallbackInterface;
    private readonly InputAction m_Standard_MoveSideWays;
    private readonly InputAction m_Standard_MoveHeightWays;
    public struct StandardActions
    {
        private @PlayerControls m_Wrapper;
        public StandardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveSideWays => m_Wrapper.m_Standard_MoveSideWays;
        public InputAction @MoveHeightWays => m_Wrapper.m_Standard_MoveHeightWays;
        public InputActionMap Get() { return m_Wrapper.m_Standard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardActions set) { return set.Get(); }
        public void SetCallbacks(IStandardActions instance)
        {
            if (m_Wrapper.m_StandardActionsCallbackInterface != null)
            {
                @MoveSideWays.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnMoveSideWays;
                @MoveSideWays.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnMoveSideWays;
                @MoveSideWays.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnMoveSideWays;
                @MoveHeightWays.started -= m_Wrapper.m_StandardActionsCallbackInterface.OnMoveHeightWays;
                @MoveHeightWays.performed -= m_Wrapper.m_StandardActionsCallbackInterface.OnMoveHeightWays;
                @MoveHeightWays.canceled -= m_Wrapper.m_StandardActionsCallbackInterface.OnMoveHeightWays;
            }
            m_Wrapper.m_StandardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveSideWays.started += instance.OnMoveSideWays;
                @MoveSideWays.performed += instance.OnMoveSideWays;
                @MoveSideWays.canceled += instance.OnMoveSideWays;
                @MoveHeightWays.started += instance.OnMoveHeightWays;
                @MoveHeightWays.performed += instance.OnMoveHeightWays;
                @MoveHeightWays.canceled += instance.OnMoveHeightWays;
            }
        }
    }
    public StandardActions @Standard => new StandardActions(this);
    public interface IStandardActions
    {
        void OnMoveSideWays(InputAction.CallbackContext context);
        void OnMoveHeightWays(InputAction.CallbackContext context);
    }
}
