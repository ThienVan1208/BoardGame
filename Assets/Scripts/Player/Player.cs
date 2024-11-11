using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
   [SerializeField] private CellIndicator detectCellMove;
   [SerializeField] private float speed;
   [SerializeField] private SOGameManager gameManagerSO;

   // This function subcribes moveEvent in gameManagerSO
   private void MoveToCellPos(){
        Vector3 cellPos = detectCellMove.getPos;
        float dis = Vector3.Distance(cellPos, transform.position);
        float timeToMove = dis / speed;
        transform.DOMove(cellPos, timeToMove);
   }
    private void OnEnable() {
        gameManagerSO.moveEvent.voidEvent += MoveToCellPos;
    }
    private void OnDisable() {
        gameManagerSO.moveEvent.voidEvent -= MoveToCellPos;
    }
}
