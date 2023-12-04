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
        if (!body || body.isKinematic)
            Move();
    }

    private void FixedUpdate()
    {
        if (body && !body.isKinematic)
            PhysicsMove();
    }

    void PhysicsMove()
    {
        body.velocity = direction.normalized * speed;
    }
    
    public void OnDirectionChange(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    
    void Move()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    
}
