using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehaviour : MonoBehaviour
{
    public Transform lookObj;

    public void Look()
    {
        Transform transform1;
        (transform1 = transform).LookAt(lookObj);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}
