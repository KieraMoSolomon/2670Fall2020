using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLookAtMouse : MonoBehaviour
{
    public Vector3Data mouseLocation;
    
    void Update()
    {
        Transform transform1;
        (transform1 = transform).LookAt(mouseLocation.value);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}
