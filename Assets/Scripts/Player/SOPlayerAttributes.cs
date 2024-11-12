using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerAttributesSO", menuName = "PlayerAttributesSO")]
public class SOPlayerAttributes : ScriptableObject {
    public int moveRange;
    public float speed;
    public int score;
    public SOGameManager gameManagerSO;
}

