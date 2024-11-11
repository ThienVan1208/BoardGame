using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EventChannel", menuName = "IntEventChannel")]
public class IntEventChannelSO : ScriptableObject
{
    public event Action<int> intEvent;
    public void RaisedEvent(int intnum){
        intEvent?.Invoke(intnum);
    }
}
