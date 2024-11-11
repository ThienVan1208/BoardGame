using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SOGameManager gameManagerSO;
    [SerializeField] private Button endMoveButton;
    private void OnEnable()
    {
        gameManagerSO.beginMoveEvent.voidEvent += ActiveEndMoveBut;
        gameManagerSO.endMoveEvent.voidEvent += InactiveEndMoveBut;
    }
    private void OnDisable()
    {
        gameManagerSO.beginMoveEvent.voidEvent -= ActiveEndMoveBut;
        gameManagerSO.endMoveEvent.voidEvent -= InactiveEndMoveBut;
    }

    private void Start()
    {
        endMoveButton.gameObject.SetActive(false);
    }
    public void ActiveRollEvent()
    {
        gameManagerSO.rollEvent.RaisedEvent();
    }
    public void ActiveBeginMoveEvent()
    {
        gameManagerSO.beginMoveEvent.RaisedEvent();
    }
    public void ActiveEndMoveEvent(){
        gameManagerSO.endMoveEvent.RaisedEvent();
    }
    private void ActiveEndMoveBut()
    {
        endMoveButton.gameObject.SetActive(true);
    }
    private void InactiveEndMoveBut()
    {
        endMoveButton.gameObject.SetActive(false);
    }

}
