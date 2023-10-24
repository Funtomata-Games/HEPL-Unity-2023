using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;
    public Rigidbody2D body;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        PhysicsMove();
    }


    public void OnDirectionChange(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    private void PhysicsMove()
    {
        if (body && !body.isKinematic)
            body.velocity = direction * speed;
    }
   
    private void Move()
    {
        if (!body || body.isKinematic)
            transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
    }
}
