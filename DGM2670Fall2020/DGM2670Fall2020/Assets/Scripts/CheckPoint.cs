using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public SpawnData checkPoint;
    private void OnTriggerEnter(Collider other)
    {
        checkPoint.SetValueFromTransform(transform.position);
    }
}
