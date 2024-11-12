using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Instruction : MonoBehaviour
{
    [SerializeField] private SOGameManager gameManagerSO;
    [SerializeField] private GameObject instructionPanel;
    private void OnEnable() {
        gameManagerSO.instruction = gameManagerSO.gameControl.Instruction.OpenInstruction;
        gameManagerSO.instruction.Enable();
        gameManagerSO.instruction.performed += UseInstruction;
    }
    private void OnDisable() {
        gameManagerSO.instruction.Disable();
    }
    private void Start() {
        instructionPanel.SetActive(false);
    }
    private void UseInstruction(InputAction.CallbackContext context){
        instructionPanel.SetActive(!instructionPanel.activeSelf);
    }

}
