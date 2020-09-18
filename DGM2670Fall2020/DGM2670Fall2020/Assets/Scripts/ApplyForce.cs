using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;

    public FloatData force;
    public GameObject obj;
    
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = new  Vector3(force.value, 0, 0);
        var forceRotaion = obj.transform.rotation.eulerAngles;
        //force direction needs to be based on player rotation (hint Scriptable Object)
        rBody.AddRelativeForce(forceDirection);
        rBody.AddRelativeForce(forceRotaion);
    }
}
