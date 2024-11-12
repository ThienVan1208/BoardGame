
using UnityEngine;
using UnityEngine.InputSystem;
[CreateAssetMenu(fileName = "gameManager", menuName = "GameManger")]

/*
 This class contains events, inputActions
*/
public class SOGameManager : ScriptableObject
{
    public VoidEventChannelSO rollEvent;
    public VoidEventChannelSO moveEvent;
    public VoidEventChannelSO endMoveEvent;
    public VoidEventChannelSO beginMoveEvent;
    public VoidEventChannelSO playerTurnEvent;
    public VoidEventChannelSO enemyTurnEvent;
    public VoidEventChannelSO endTurnEvent;

    public GameControl gameControl;// New input system
    public InputAction beginMove;
    public InputAction endMove;
    public InputAction rollDice;
    //public InputAction playerMove;// in CellIndicator

    // This is used in Instruction.
    public InputAction instruction;
    
    /*
    * This is used in CellIndicator, in Update method, when click mouse left
    * The variable moveEvent is subcribed by Player
    */
    public void ActiveMoveEvent()
    {
        moveEvent.RaisedEvent();
    }
    
   

    /*
    * This lies in BeginMove func.
    * This is used in new input system, button 1Alpha.
    * The subscription is executed in GameManager OnEnable func.
    * Include: DetectCellMove.
    */
    public void ActiveBeginMoveEvent()
    {
        beginMoveEvent.RaisedEvent();
    }
    public void BeginMove(InputAction.CallbackContext context)
    {
        ActiveBeginMoveEvent();
    }


    /*
    * This lies in EndMove func.
    * This is used in new input system, button Q.
    * The subscription is executed in GameManager OnEnable func.
    * Include: DetectCellMove.
    */
    public void ActiveEndMoveEvent()
    {
        endMoveEvent.RaisedEvent();
    }
    public void EndMove(InputAction.CallbackContext context)
    {
        ActiveEndMoveEvent();
    }

    /*
    * This lies in RollDice func.
    * This is used in new input system, button 2Alpha.
    * The subscription is executed in GameManager OnEnable func.
    */
    public void ActiveRollEvent()
    {
        rollEvent.RaisedEvent();
    }
    public void RollDice(InputAction.CallbackContext context)
    {
        ActiveRollEvent();
    }


    /*
    * 2 methods below is used to trigger player/enemy turn in button canvas.
    */
    public void PlayerTurnEvent(){
        playerTurnEvent.RaisedEvent();
    }
    public void EnemyTurnEvent(){
        enemyTurnEvent.RaisedEvent();
        ActiveEndMoveEvent();
    }

    public void EndTurnEvent(){
        endTurnEvent.RaisedEvent();
        ActiveEndMoveEvent();
    }
}
