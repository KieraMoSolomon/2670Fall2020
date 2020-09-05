using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMovePattern : MonoBehaviour
{
    public MoveData newMovePattern;
    public void OnTriggerEnter(Collider obj)
    {
        obj.GetComponent<CharacterMovement>().movePattern = newMovePattern;
        gameObject.SetActive(false);
    }
}
