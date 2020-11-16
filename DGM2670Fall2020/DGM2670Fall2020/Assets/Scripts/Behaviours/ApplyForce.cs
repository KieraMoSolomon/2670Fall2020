using System;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    //direction of hit
    //run coroutine on a hit
    
    private Rigidbody rBody;
    public Vector3 forces;

    public bool canRunOnStart;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        if (canRunOnStart)
        {
            OnApplyForce();
        }
    }

    public void OnApplyForce()
    {
        rBody.AddRelativeForce(forces);
    }
}