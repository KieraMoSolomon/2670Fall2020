using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookObj;

    public void Update()
    {
        transform.LookAt(lookObj);
    }
}
