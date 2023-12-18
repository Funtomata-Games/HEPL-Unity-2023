using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject explosion;
    
    public void Kill()
    {
        if (explosion) Explode();
        Destroy(gameObject);
    }

    private void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
    
    
}
