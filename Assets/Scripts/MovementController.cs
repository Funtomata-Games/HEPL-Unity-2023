using System;
using UnityEngine;
using UnityEngine.InputSystem;

//hello//

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;
    public Rigidbody2D body;

    public void OnDirectionChange(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (body == false || body.isKinematic)
        {
            transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        }
    }

    private void FixedUpdate()
    {
        if (body == true && body.isKinematic == false)
        {
            var targetVelocity = speed * direction - body.velocity;
            body.AddForce(body.mass * targetVelocity, ForceMode2D.Impulse);
        }
    }
}
