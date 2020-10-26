using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    public MoveData movePattern;
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
        movePattern.Move(controller, transform);
    }
    
    
        public Vector3 knockBackVector;
        public float knockBackForce = 10f;
        /*private float tempForce;
        //private float countDown;

        private void Start()
        {
            tempForce = knockBackForce;
        }*/
    
        private IEnumerator KnockBack(ControllerColliderHit hit)
        {
            var i = 2f;
            knockBackVector = hit.collider.attachedRigidbody.velocity * i;
            while (i > 0)
            {
                yield return new WaitForFixedUpdate();
                i -= 0.1f;
            }
        }

        public float pushPower = 10.0f;

        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            var body = hit.collider.attachedRigidbody;

            if (body == null || body.isKinematic)
            {
                return;
            }

            if (hit.moveDirection.y < -0.3)
            {
                return;   
            } 
            StartCoroutine(KnockBack(hit));
            var pushDirection = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
            body.velocity = pushDirection * pushPower;
        }
}