using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    public FloatData speed;
    public FloatData jumpForce;
    public FloatData gravity;

    public FloatData moveX, moveY, moveZ;
    
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection.Set(moveX.value, moveY.value, moveZ.value);
            moveDirection = transform.TransformDirection((moveDirection));
            moveDirection = speed.value * moveDirection;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpForce.value;
            }
        }

        moveDirection.y -= gravity.value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
