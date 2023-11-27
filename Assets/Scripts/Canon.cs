using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectile;

    private void Fire()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }

    public void OnFirePressed(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started) 
            Fire();
    }
}
