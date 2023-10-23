using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;
    public Rigidbody2D body;

    public void OnDirectionChange(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>().normalized;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!body || body.isKinematic)
        {
            transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        }

    }

    private void FixedUpdate()
    {
        if (body && body.isKinematic == false)
        {
            body.velocity = speed * direction;
        }
    }
}
