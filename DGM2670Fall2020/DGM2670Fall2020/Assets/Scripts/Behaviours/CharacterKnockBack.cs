using System;
using System.Collections;
using UnityEngine;

public class CharacterKnockBack : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 knockBackVector, move;
    public float knockBackForce = 50f;
    private float tempForce;
    //private float countDown;

    private void Start()
    {
        tempForce = knockBackForce;
    }
    
    private IEnumerator KnockBack(ControllerColliderHit hit)
    {
        var i = 2f;
        move = hit.collider.attachedRigidbody.velocity * i;
        while (i > 0)
        {
            yield return new WaitForFixedUpdate();
            i -= 0.1f;
        }
        move = Vector3.back;
    }

    public float pushPower = 10.0f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        StartCoroutine(KnockBack(hit));
        var body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3)
        {
         return;   
        }
        
        var pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDirection * pushPower;
    }
}
