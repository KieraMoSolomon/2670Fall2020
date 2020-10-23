using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    //direction of hit
    //run coroutine on a hit
    
    private Rigidbody rBody;

    public FloatData force;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new Vector3(force.value, 0,0);
        rBody.AddRelativeForce(forceDirection);
    }
}
