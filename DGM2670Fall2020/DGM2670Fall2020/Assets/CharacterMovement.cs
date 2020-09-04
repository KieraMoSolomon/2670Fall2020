using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    public FloatData speed;
    public FloatData jumpForce;
    public FloatData gravity, rotateSpeed;
    public IntData jumpCount ,jumpCountMax;
    private float yVar;
    private Vector3 moveDirection;
    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var vInput = Input.GetAxis("Vertical") * speed.value;
            moveDirection.Set(vInput, yVar, 0);

            var hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed.value;
            transform.Rotate(0, hInput, 0);

            yVar -= gravity.value * Time.deltaTime;

            if (controller.isGrounded && moveDirection.y < 0)
            {
                yVar = -1f;
                jumpCount.value = 0;
            }

            if (Input.GetButtonDown("Jump") && jumpCount.value < jumpCountMax.value)
            {
                yVar = jumpForce.value;
                jumpCount.value++;
            }

            moveDirection = transform.TransformDirection(moveDirection);
        controller.Move(moveDirection * Time.deltaTime);
    }
}
