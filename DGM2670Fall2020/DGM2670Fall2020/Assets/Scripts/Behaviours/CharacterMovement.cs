using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    /*public FloatData walkSpeed, runSpeed;
    public FloatData jumpForce;
    public FloatData gravity, rotateSpeed;
    public IntData jumpCount ,jumpCountMax;
    public BoolData canJump;*/
    public MoveData movePattern;
    private Vector3 moveDirection;
    private CharacterController controller;

    public Vector3Data currentSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movePattern.Move(controller, transform);
    }

    private void OnEnable()
    {
        transform.position = currentSpawnPoint.value;
    }
}
