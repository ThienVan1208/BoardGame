using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class DiceBehaviour : MonoBehaviour
{
    
    public Rigidbody rb;
    //15.57397 0.8829718 3.579147
    private Vector3 finalPos = new Vector3(15.57397f, 0.8829718f, 3.579147f);
    private Vector3 initPos = new Vector3(-6f, 9f, 0f);
    [SerializeField] private IntEventChannelSO SODetectDiceFaceEvent;
    //[SerializeField] private VoidEventChannelSO rollEvent;
    [SerializeField] private float forceRoll;
    [SerializeField] private List<GameObject> listDiceSurface;
    [SerializeField] private TextMeshProUGUI diceFaceTxt;

    private void OnEnable()
    {
        // Subscribe to event
        SODetectDiceFaceEvent.intEvent += DisplayDiceFace;
        //rollEvent.voidEvent += RollDice;
    }

    private void OnDisable()
    {
        // Unsubscribe from event to prevent memory leaks
        SODetectDiceFaceEvent.intEvent -= DisplayDiceFace;
        //rollEvent.voidEvent -= RollDice;
    }

    private void Start() {
        SetInactiveAllFaceDice();
        InactiveDice();

    }
    public void RollDice()
    {
        //transform.DOMove(finalPos, 2f).SetEase(Ease.InOutQuad);
        SetInactiveAllFaceDice();
        rb.AddForce((finalPos - initPos) * 100f);
        var xRan = Random.Range(-180, 360);
        var yRan = Random.Range(-180, 360);
        var zRan = Random.Range(-180, 360);
        Vector3 vecRan = new Vector3(xRan, yRan, zRan);
        rb.AddTorque(transform.eulerAngles + vecRan * forceRoll);
        //transform.DORotate(transform.eulerAngles + vecRan * forceRoll, 2f);
    }

    private void DisplayDiceFace(int faceDice)
    {
        Debug.Log(faceDice);
        ShowTextDiceFace(faceDice);
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
    public void InactiveDice(){
        gameObject.SetActive(false);
        transform.position = initPos;
    }

    private void ShowTextDiceFace(int faceDice){
        diceFaceTxt.text = faceDice.ToString();
        Sequence sequence = DOTween.Sequence();
        
        // First, fade in
        sequence.Append(diceFaceTxt.DOFade(1, 0.2f));
        
        // Then, fade out after the fade-in completes
        sequence.Append(diceFaceTxt.DOFade(0, 3f));
    }
    IEnumerator FadeEffect(){
        diceFaceTxt.DOFade(1, 0.2f);
        yield return new WaitForSeconds(0.2f);
    }
}
