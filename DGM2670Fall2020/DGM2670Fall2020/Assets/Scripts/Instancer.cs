﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    //Make a method to call the instance Method
    public void Instance()
    {
        var location = transform.position;
        var rotationDirection = new Vector3(0f, 45f, 0f);
        Instantiate(prefab, location, Quaternion.Euler(rotationDirection));
    }
}
