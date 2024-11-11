using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "gameManager", menuName = "GameManger")]
public class SOGameManager : ScriptableObject
{
    public VoidEventChannelSO rollEvent;
    public VoidEventChannelSO moveEvent;
    public VoidEventChannelSO endMoveEvent;
    public VoidEventChannelSO beginMoveEvent;
    public void ActiveMoveEvent(){
        moveEvent.RaisedEvent();
    }
    public void ActiveRollEvent(){
        rollEvent.RaisedEvent();
    }
    public void ActiveBeginMoveEvent(){
        beginMoveEvent.RaisedEvent();
    }
}
