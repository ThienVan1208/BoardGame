using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceParent : MonoBehaviour
{
    [SerializeField] VoidEventChannelSO rollEvent;
    [SerializeField] private DiceBehaviour dice;
    private void ActiveDice(){
        dice.gameObject.SetActive(true);
    }
    private void OnEnable() {
        rollEvent.voidEvent += ActiveDice;
        rollEvent.voidEvent += dice.RollDice;
    }
    private void OnDisable() {
        rollEvent.voidEvent -= ActiveDice;
        rollEvent.voidEvent -= dice.RollDice;
    }
}
