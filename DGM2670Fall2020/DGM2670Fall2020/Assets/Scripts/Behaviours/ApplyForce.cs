using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    //direction of hit
    //run coroutine on a hit
    
    private Rigidbody rBody;
    public Vector3 forces;

    public void OnApplyForce()
    {
        rBody = GetComponent<Rigidbody>();
        rBody.AddRelativeForce(forces);
    }
}