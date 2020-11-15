using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterWithStates : MonoBehaviour
{
    private CharacterController controller;
    public CharacterStateMachineData characterStates;

    private Vector3 movement;
    private float speed;
    public float moveSpeed = 3;
    public float gravity = -9.81f;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        
        var hInput = Input.GetAxis("Vertical")*moveSpeed;

        switch (characterStates.value)
        { 
            case CharacterStateMachineData.characterStates.StandardWalk:
                movement.Set(hInput,gravity,0);
                print("Standard Walk");
                break;
             case CharacterStateMachineData.characterStates.WallCrawl:
                 movement.Set(0, hInput, 0);
                 print("Wall Crawl");
                 break;
             case CharacterStateMachineData.characterStates.Idle:
                 print("Idle");
                 break;
             case CharacterStateMachineData.characterStates.NoGravWalk:
                 movement.Set(hInput,0,0);
                 print("NoGravity");
                 break;
        }

        var newMovement = movement * Time.deltaTime;
        controller.Move(newMovement);
    }
}
