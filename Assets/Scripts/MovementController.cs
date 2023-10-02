using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 direction;
    public int speed;

    public void OnDirectionChange(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
    }
}
