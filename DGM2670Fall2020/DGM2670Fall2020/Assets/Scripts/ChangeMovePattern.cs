using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMovePattern : MonoBehaviour
{
    public MoveData newMovePattern;
    public void OnTriggerEnter(Collider obj)
    {
        Debug.Log("hit");
        obj.GetComponent<CharacterMovement>().movePattern = newMovePattern;
        gameObject.SetActive(false);
    }
}
