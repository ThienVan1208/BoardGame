using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO SODetectDiceFaceEvent;

    [SerializeField] private DiceBehaviour dice;
    private void OnTriggerEnter(Collider other)
    {
        int faceDice = int.Parse(other.gameObject.name);
        SODetectDiceFaceEvent.RaisedEvent(faceDice);
    }
    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(waitToCheckDiceFace());
    }
    private IEnumerator waitToCheckDiceFace()
    {
        yield return new WaitUntil(() => dice.rb.velocity == Vector3.zero);
        dice.SetActiveAllFaceDice();
        yield return new WaitForSeconds(1f);
        dice.InactiveDice();
    }
}
