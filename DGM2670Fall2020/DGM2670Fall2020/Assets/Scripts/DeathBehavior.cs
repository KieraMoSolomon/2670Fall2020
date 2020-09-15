using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DeathBehavior : MonoBehaviour
{
    public SpawnData startPoint;
    private Vector3 deathSpawn;
    public void OnTriggerEnter(Collider other)
    {
        deathSpawn = startPoint.value;
        Debug.Log("Trigger!!!!");
        //other.transform.position = startPoint.value;
        
        other.gameObject.transform.position = deathSpawn;
        
    }
}
