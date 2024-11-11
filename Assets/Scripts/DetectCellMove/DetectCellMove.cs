using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCellMove : MonoBehaviour
{
    [SerializeField] private GameObject cellIndicator;
    
    [SerializeField] private SOGameManager gameManagerSO;
    private void Start()
    {
        InactiveDetection();
    }
    private void OnEnable() {
        gameManagerSO.beginMoveEvent.voidEvent += ActiveDetection;
        gameManagerSO.endMoveEvent.voidEvent += InactiveDetection;
    }
    private void OnDisable() {
        gameManagerSO.beginMoveEvent.voidEvent -= ActiveDetection;
        gameManagerSO.endMoveEvent.voidEvent-= InactiveDetection;
    }
    private void ActiveDetection()
    {
        cellIndicator.SetActive(true);
    }
    private void InactiveDetection()
    {
        cellIndicator.SetActive(false);
    }

}
