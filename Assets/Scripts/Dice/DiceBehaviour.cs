using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DiceBehaviour : MonoBehaviour
{
    
    public Rigidbody rb;
    private float yGround = 0.8826801f;
    [SerializeField] private IntEventChannelSO SODetectDiceFaceEvent;
    [SerializeField] private VoidEventChannelSO rollEvent;
    [SerializeField] private float forceRoll;
    [SerializeField] private List<GameObject> listDiceSurface;

    private void OnEnable()
    {
        // Subscribe to event
        SODetectDiceFaceEvent.intEvent += DisplayDiceFace;
        rollEvent.voidEvent += RollDice;
    }

    private void OnDisable()
    {
        // Unsubscribe from event to prevent memory leaks
        SODetectDiceFaceEvent.intEvent -= DisplayDiceFace;
        rollEvent.voidEvent -= RollDice;
    }

    private void Start() {
        SetInactiveAllFaceDice();
    }
    private void RollDice()
    {

        SetInactiveAllFaceDice();
        rb.AddForce(Vector3.up * forceRoll);
        var xRan = Random.Range(-180, 360);
        var yRan = Random.Range(-180, 360);
        var zRan = Random.Range(-180, 360);
        Vector3 vecRan = new Vector3(xRan, yRan, zRan);
        rb.AddTorque(vecRan * 2f);
    }

    private void DisplayDiceFace(int faceDice)
    {
        Debug.Log(faceDice);
    }

    public void SetActiveAllFaceDice(){
        foreach(var dice in listDiceSurface){
            dice.SetActive(true);
        }
    }
    public void SetInactiveAllFaceDice(){
        foreach(var dice in listDiceSurface){
            dice.SetActive(false);
        }
    }
}
