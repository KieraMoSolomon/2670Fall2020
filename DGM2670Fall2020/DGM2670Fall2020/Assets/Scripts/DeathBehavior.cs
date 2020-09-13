using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DeathBehavior : MonoBehaviour
{
    public SpawnData startPoint;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = startPoint.valueX;
    }
}
