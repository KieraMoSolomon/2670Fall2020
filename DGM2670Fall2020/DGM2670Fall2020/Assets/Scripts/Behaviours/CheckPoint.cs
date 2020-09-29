using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public Vector3Data checkPoint;
    private void OnTriggerEnter(Collider other)
    {
        checkPoint.SetValueFromVector3(transform.position);
    }
}
