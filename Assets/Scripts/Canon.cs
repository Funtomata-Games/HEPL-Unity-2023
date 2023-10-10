using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectile;

    public void OnFirePressed(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Fire();
        }
    }
    
    void Fire()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }
}
