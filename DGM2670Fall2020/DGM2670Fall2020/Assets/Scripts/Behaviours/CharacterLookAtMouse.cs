using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLookAtMouse : MonoBehaviour
{
    public Vector3Data mouseLocation;
    
    
    public FloatData walkSpeed, runSpeed;
    public FloatData jumpForce;
    public FloatData gravity, rotateSpeed;
    public IntData jumpCount ,jumpCountMax;
    public BoolData canJump;
    public float yVar;
    private Vector3 moveDirection;
    
    private CharacterController controller;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Transform transform1;
        (transform1 = transform).LookAt(mouseLocation.value);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transformRotation.z = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
        
        
        var vInput = Input.GetAxis("Vertical") * SpeedSet();
        moveDirection.Set(vInput, yVar, 0);

        yVar -= gravity.value * Time.deltaTime;

        if (controller.isGrounded && moveDirection.y < 0)
        {
            jumpCount.value = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount.value <= jumpCountMax.value && canJump.value)
        {
            yVar = jumpForce.value;
            jumpCount.value++;
        }

        moveDirection = transform.TransformDirection(moveDirection);
        controller.Move(moveDirection * Time.deltaTime);
    }

    private float SpeedSet()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            return runSpeed.value;
        }
        else
        {
            return walkSpeed.value;
        }
    }
}
