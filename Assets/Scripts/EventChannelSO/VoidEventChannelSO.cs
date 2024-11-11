using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EventChannel", menuName = "VoidEventChannel")]
public class VoidEventChannelSO : ScriptableObject
{
    public event Action voidEvent;
    public void RaisedEvent(){
        voidEvent?.Invoke();
    }
}
