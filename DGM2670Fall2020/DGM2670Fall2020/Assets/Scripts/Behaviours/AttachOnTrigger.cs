using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = transform;
        //transform.parent = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
