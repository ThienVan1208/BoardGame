
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SOGameManager gameManagerSO;
    [SerializeField] private TextMeshProUGUI turnTxt;
    [SerializeField] private GameObject endMoveButton, endTurnButton, rollButton;
    [SerializeField] private GameObject playerTurnButtonGr, turnButtonGr;
    private void Awake()
    {
        gameManagerSO.gameControl = new GameControl();
    }
    private void Start()
    {
        InactiveEndMoveBut();
        playerTurnButtonGr.SetActive(false);
        endTurnButton.SetActive(false);
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

        // Subcribe EndMove button event
        gameManagerSO.beginMoveEvent.voidEvent += ActiveEndMoveBut;
        gameManagerSO.beginMoveEvent.voidEvent += InactiveRollDiceBut;

        gameManagerSO.endMoveEvent.voidEvent += InactiveEndMoveBut;
        gameManagerSO.endMoveEvent.voidEvent += ActiveRollDiceBut;

        // This subscribes Player/Enemy turn button event
        gameManagerSO.playerTurnEvent.voidEvent += SetActivePlayerTurnButtonGr;
        gameManagerSO.enemyTurnEvent.voidEvent += SetActiveEnemyTurnButtonGr;

        gameManagerSO.playerTurnEvent.voidEvent += InactiveTurnButtonGr;
        gameManagerSO.enemyTurnEvent.voidEvent += InactiveTurnButtonGr;

        gameManagerSO.endTurnEvent.voidEvent += ActiveTurnButtonGr;
    }
    private void OnDisable()
    {
        gameManagerSO.beginMove.Disable();
        gameManagerSO.endMove.Disable();
        gameManagerSO.rollDice.Disable();

        gameManagerSO.beginMoveEvent.voidEvent -= ActiveEndMoveBut;
        gameManagerSO.beginMoveEvent.voidEvent -= InactiveRollDiceBut;

        gameManagerSO.endMoveEvent.voidEvent -= InactiveEndMoveBut;
        gameManagerSO.endMoveEvent.voidEvent -= ActiveRollDiceBut;

        gameManagerSO.playerTurnEvent.voidEvent -= SetActivePlayerTurnButtonGr;
        gameManagerSO.enemyTurnEvent.voidEvent -= SetActiveEnemyTurnButtonGr;

        gameManagerSO.playerTurnEvent.voidEvent -= InactiveTurnButtonGr;
        gameManagerSO.enemyTurnEvent.voidEvent -= InactiveTurnButtonGr;

        gameManagerSO.endTurnEvent.voidEvent -= ActiveTurnButtonGr;
    }
    private void ActiveRollDiceBut(){
        rollButton.SetActive(true);
    }
    private void InactiveRollDiceBut(){
        rollButton.SetActive(false);
    }
    private void InactiveEndMoveBut()
    {
        endMoveButton.SetActive(false);
    }
    private void ActiveEndMoveBut()
    {
        endMoveButton.SetActive(true);
    }
    private void SetActivePlayerTurnButtonGr(){
        playerTurnButtonGr.SetActive(true);
    }
    private void SetActiveEnemyTurnButtonGr(){
        playerTurnButtonGr.SetActive(false);
    }
    private void ActiveTurnButtonGr(){
        endTurnButton.SetActive(false);
        turnButtonGr.SetActive(true);
    }
    private void InactiveTurnButtonGr(){
        turnButtonGr.SetActive(false);
    }

    // They are used in button canvas.
    public void ActiveBeginMoveEvent()
    {
        gameManagerSO.ActiveBeginMoveEvent();
    }
    public void ActiveRollEvent()
    {
        gameManagerSO.ActiveRollEvent();
    }
    public void ActiveEndMoveEvent()
    {
        gameManagerSO.ActiveEndMoveEvent();
    }
    //*************************************************
    
     
    private void setTurnStr(string turnStr)
    {
        turnTxt.text = "Turn: " + turnStr;
    }

    // 2 methods below are used in button canvas
    public void PlayerTurn()
    {
        setTurnStr("Player");
        endTurnButton.SetActive(true);
        gameManagerSO.PlayerTurnEvent();
    }
    public void EnemyTurn(){
        setTurnStr("Enemy");
        endTurnButton.SetActive(true);
        gameManagerSO.EnemyTurnEvent();
    }
    
    public void EndTurn(){
        gameManagerSO.EndTurnEvent();
        playerTurnButtonGr.SetActive(false);
    }
}

