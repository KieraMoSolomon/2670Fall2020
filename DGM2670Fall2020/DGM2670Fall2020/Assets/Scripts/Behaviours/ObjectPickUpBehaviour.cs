using System;
using UnityEngine;

public class ObjectPickUpBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    private bool canPickUp;
    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        canPickUp = Input.GetKeyDown(KeyCode.P);
    }

    private void OnTriggerStay(Collider other)
    {
        if (canPickUp)
        {
            transform.parent = other.transform;
            rBody.isKinematic = true;
            rBody.useGravity = false;
        }
        else
            transform.parent = null;
            rBody.isKinematic = false;
            rBody.useGravity = true;
    }
}
