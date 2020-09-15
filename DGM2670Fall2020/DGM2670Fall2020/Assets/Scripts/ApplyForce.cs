using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;

    public FloatData force;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new  Vector3(force.value, 0, 0);
        //force direction needs to be based on player rotation (hint Scriptable Object)
        rBody.AddRelativeForce(forceDirection);
        
    }
    //need a firing Method
}
