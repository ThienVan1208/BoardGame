using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellIndicator : MonoBehaviour
{
    [SerializeField] private Camera sceneCamera;
    [SerializeField] private LayerMask placeLayerMask;
    [SerializeField] private Grid grid;
    [SerializeField] SOGameManager gameManagerSO;
    public Vector3 getPos;
    private void FollowMousePos()
    {
        Vector3 mousePos = Input.mousePosition;

        // Set the Z value to the camera's distance from the grid
        mousePos.z = sceneCamera.nearClipPlane;
        Ray ray = sceneCamera.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 1000, placeLayerMask)){
            getPos = hit.point;
            Vector3Int cellPos = grid.WorldToCell(getPos);
            getPos = grid.GetCellCenterWorld(cellPos);
        }
        transform.position = getPos;
    }
    private void Update() {
        FollowMousePos();
        if(Input.GetMouseButtonDown(0)){
            gameManagerSO.ActiveMoveEvent();
        }
    }
}
