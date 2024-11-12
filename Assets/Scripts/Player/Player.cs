using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
   [SerializeField] private CellIndicator detectCellMove;
   [SerializeField] private SOPlayerAttributes playerAttributesSO;

   // This function subcribes moveEvent in gameManagerSO
   private void MoveToCellPos(){
        Vector3 cellPos = detectCellMove.getPos;
        float dis = Vector3.Distance(cellPos, transform.position);
        float timeToMove = dis / playerAttributesSO.speed;
        transform.DOMove(cellPos, timeToMove);
   }
    private void OnEnable() {
        playerAttributesSO.gameManagerSO.moveEvent.voidEvent += MoveToCellPos;
    }
    private void OnDisable() {
        playerAttributesSO.gameManagerSO.moveEvent.voidEvent -= MoveToCellPos;
    }
}
