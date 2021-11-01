using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float tankSpeed;
    public Rigidbody tankRigidBody;
    public float movementInput;
    public float turnInput;
    public float movementSpeed;
    public float turnSpeed;
   
    void Start()
    {
    tankRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();
        Turn();
    }

    // Update is called once per frame
    void Update()
    {
        turnInput = Input.GetAxis("Horizontal");
        movementInput = Input.GetAxis("Vertical");
    }
     private void Turn()
    {
        //turnInput is multiplied by turnSpeed to get a good number and then restrains the time cycle to roughly a second
        float turn = turnInput * turnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0, turn, 0);
        tankRigidBody.MoveRotation(tankRigidBody.rotation * turnRotation);
    }

    private void Move()
    {
        Vector3 movement = -transform.forward * movementInput * tankSpeed * Time.deltaTime;

        tankRigidBody.MovePosition(tankRigidBody.position + movement);
    }
}
