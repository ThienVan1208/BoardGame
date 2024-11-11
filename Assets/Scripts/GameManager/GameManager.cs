
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SOGameManager gameManagerSO;
    
    
    private void Awake()
    {
        gameManagerSO.gameControl = new GameControl();
    }
    private void OnEnable()
    {
        // Subcribe beginMove
        gameManagerSO.beginMove = gameManagerSO.gameControl.MoveEvent.BeginMove;
        gameManagerSO.beginMove.Enable();
        gameManagerSO.beginMove.performed += gameManagerSO.BeginMove;

        // Subcribe endMove
        gameManagerSO.endMove = gameManagerSO.gameControl.MoveEvent.EndMove;
        gameManagerSO.endMove.Enable();
        gameManagerSO.endMove.performed += gameManagerSO.EndMove;

        // Subcribe rollDice
        gameManagerSO.rollDice = gameManagerSO.gameControl.MoveEvent.RollDice;
        gameManagerSO.rollDice.Enable();
        gameManagerSO.rollDice.performed += gameManagerSO.RollDice;


    }
    private void OnDisable()
    {
        gameManagerSO.beginMove.Disable();
        gameManagerSO.endMove.Disable();
        gameManagerSO.rollDice.Disable();
    }

}

