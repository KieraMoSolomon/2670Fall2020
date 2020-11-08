using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointFromMouse : MonoBehaviour
{
    private Camera cam;
    public Vector3Data mouseLocation;
    public void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition),out var hit, 100))
        {
            mouseLocation.value = hit.point;
        }
    }
}
