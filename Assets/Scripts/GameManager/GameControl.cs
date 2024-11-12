//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/GameManager/GameControl.inputactions
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

public partial class @GameControl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControl"",
    ""maps"": [
        {
            ""name"": ""MoveEvent"",
            ""id"": ""82ee9d8f-89bd-493f-aa40-dacb096f0dc0"",
            ""actions"": [
                {
                    ""name"": ""BeginMove"",
                    ""type"": ""Button"",
                    ""id"": ""c13eb4f1-bda0-4552-a551-0bad26b1245d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EndMove"",
                    ""type"": ""Button"",
                    ""id"": ""4316614c-f0ba-44da-82a9-0e5822806185"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RollDice"",
                    ""type"": ""Button"",
                    ""id"": ""1fc00d4f-a666-441e-84ac-245903841425"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eeb0e608-0e50-4739-ab1f-0e56efd5f179"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BeginMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03c3561f-c518-45f4-8eb4-7409b51370ca"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EndMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""893b1d67-34c7-42b6-a63c-fa755586fcf8"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RollDice"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CharMoveEvent"",
            ""id"": ""1551ba31-3f61-4770-8efe-864152140837"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Button"",
                    ""id"": ""cc335734-f307-4652-a02f-7837131feecd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33df91e1-6052-4178-ab40-8f0dd929a90d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Instruction"",
            ""id"": ""3999b4c0-c991-4a6b-a939-ee8898815e68"",
            ""actions"": [
                {
                    ""name"": ""OpenInstruction"",
                    ""type"": ""Button"",
                    ""id"": ""a02e8d60-476b-4117-bc1c-5d051880ee5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a403b8e9-a077-4e26-ae71-9b22ab893249"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenInstruction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MoveEvent
        m_MoveEvent = asset.FindActionMap("MoveEvent", throwIfNotFound: true);
        m_MoveEvent_BeginMove = m_MoveEvent.FindAction("BeginMove", throwIfNotFound: true);
        m_MoveEvent_EndMove = m_MoveEvent.FindAction("EndMove", throwIfNotFound: true);
        m_MoveEvent_RollDice = m_MoveEvent.FindAction("RollDice", throwIfNotFound: true);
        // CharMoveEvent
        m_CharMoveEvent = asset.FindActionMap("CharMoveEvent", throwIfNotFound: true);
        m_CharMoveEvent_PlayerMovement = m_CharMoveEvent.FindAction("PlayerMovement", throwIfNotFound: true);
        // Instruction
        m_Instruction = asset.FindActionMap("Instruction", throwIfNotFound: true);
        m_Instruction_OpenInstruction = m_Instruction.FindAction("OpenInstruction", throwIfNotFound: true);
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

    // MoveEvent
    private readonly InputActionMap m_MoveEvent;
    private List<IMoveEventActions> m_MoveEventActionsCallbackInterfaces = new List<IMoveEventActions>();
    private readonly InputAction m_MoveEvent_BeginMove;
    private readonly InputAction m_MoveEvent_EndMove;
    private readonly InputAction m_MoveEvent_RollDice;
    public struct MoveEventActions
    {
        private @GameControl m_Wrapper;
        public MoveEventActions(@GameControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @BeginMove => m_Wrapper.m_MoveEvent_BeginMove;
        public InputAction @EndMove => m_Wrapper.m_MoveEvent_EndMove;
        public InputAction @RollDice => m_Wrapper.m_MoveEvent_RollDice;
        public InputActionMap Get() { return m_Wrapper.m_MoveEvent; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveEventActions set) { return set.Get(); }
        public void AddCallbacks(IMoveEventActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveEventActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveEventActionsCallbackInterfaces.Add(instance);
            @BeginMove.started += instance.OnBeginMove;
            @BeginMove.performed += instance.OnBeginMove;
            @BeginMove.canceled += instance.OnBeginMove;
            @EndMove.started += instance.OnEndMove;
            @EndMove.performed += instance.OnEndMove;
            @EndMove.canceled += instance.OnEndMove;
            @RollDice.started += instance.OnRollDice;
            @RollDice.performed += instance.OnRollDice;
            @RollDice.canceled += instance.OnRollDice;
        }

        private void UnregisterCallbacks(IMoveEventActions instance)
        {
            @BeginMove.started -= instance.OnBeginMove;
            @BeginMove.performed -= instance.OnBeginMove;
            @BeginMove.canceled -= instance.OnBeginMove;
            @EndMove.started -= instance.OnEndMove;
            @EndMove.performed -= instance.OnEndMove;
            @EndMove.canceled -= instance.OnEndMove;
            @RollDice.started -= instance.OnRollDice;
            @RollDice.performed -= instance.OnRollDice;
            @RollDice.canceled -= instance.OnRollDice;
        }

        public void RemoveCallbacks(IMoveEventActions instance)
        {
            if (m_Wrapper.m_MoveEventActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveEventActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveEventActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveEventActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveEventActions @MoveEvent => new MoveEventActions(this);

    // CharMoveEvent
    private readonly InputActionMap m_CharMoveEvent;
    private List<ICharMoveEventActions> m_CharMoveEventActionsCallbackInterfaces = new List<ICharMoveEventActions>();
    private readonly InputAction m_CharMoveEvent_PlayerMovement;
    public struct CharMoveEventActions
    {
        private @GameControl m_Wrapper;
        public CharMoveEventActions(@GameControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovement => m_Wrapper.m_CharMoveEvent_PlayerMovement;
        public InputActionMap Get() { return m_Wrapper.m_CharMoveEvent; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharMoveEventActions set) { return set.Get(); }
        public void AddCallbacks(ICharMoveEventActions instance)
        {
            if (instance == null || m_Wrapper.m_CharMoveEventActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharMoveEventActionsCallbackInterfaces.Add(instance);
            @PlayerMovement.started += instance.OnPlayerMovement;
            @PlayerMovement.performed += instance.OnPlayerMovement;
            @PlayerMovement.canceled += instance.OnPlayerMovement;
        }

        private void UnregisterCallbacks(ICharMoveEventActions instance)
        {
            @PlayerMovement.started -= instance.OnPlayerMovement;
            @PlayerMovement.performed -= instance.OnPlayerMovement;
            @PlayerMovement.canceled -= instance.OnPlayerMovement;
        }

        public void RemoveCallbacks(ICharMoveEventActions instance)
        {
            if (m_Wrapper.m_CharMoveEventActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharMoveEventActions instance)
        {
            foreach (var item in m_Wrapper.m_CharMoveEventActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharMoveEventActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharMoveEventActions @CharMoveEvent => new CharMoveEventActions(this);

    // Instruction
    private readonly InputActionMap m_Instruction;
    private List<IInstructionActions> m_InstructionActionsCallbackInterfaces = new List<IInstructionActions>();
    private readonly InputAction m_Instruction_OpenInstruction;
    public struct InstructionActions
    {
        private @GameControl m_Wrapper;
        public InstructionActions(@GameControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenInstruction => m_Wrapper.m_Instruction_OpenInstruction;
        public InputActionMap Get() { return m_Wrapper.m_Instruction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InstructionActions set) { return set.Get(); }
        public void AddCallbacks(IInstructionActions instance)
        {
            if (instance == null || m_Wrapper.m_InstructionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InstructionActionsCallbackInterfaces.Add(instance);
            @OpenInstruction.started += instance.OnOpenInstruction;
            @OpenInstruction.performed += instance.OnOpenInstruction;
            @OpenInstruction.canceled += instance.OnOpenInstruction;
        }

        private void UnregisterCallbacks(IInstructionActions instance)
        {
            @OpenInstruction.started -= instance.OnOpenInstruction;
            @OpenInstruction.performed -= instance.OnOpenInstruction;
            @OpenInstruction.canceled -= instance.OnOpenInstruction;
        }

        public void RemoveCallbacks(IInstructionActions instance)
        {
            if (m_Wrapper.m_InstructionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInstructionActions instance)
        {
            foreach (var item in m_Wrapper.m_InstructionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InstructionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InstructionActions @Instruction => new InstructionActions(this);
    public interface IMoveEventActions
    {
        void OnBeginMove(InputAction.CallbackContext context);
        void OnEndMove(InputAction.CallbackContext context);
        void OnRollDice(InputAction.CallbackContext context);
    }
    public interface ICharMoveEventActions
    {
        void OnPlayerMovement(InputAction.CallbackContext context);
    }
    public interface IInstructionActions
    {
        void OnOpenInstruction(InputAction.CallbackContext context);
    }
}
