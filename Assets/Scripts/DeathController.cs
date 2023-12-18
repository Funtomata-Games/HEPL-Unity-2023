
using UnityEngine;

public class DeathController : MonoBehaviour
{
    public GameObject explosion;
    public int score;
    
    public void Kill()
    {
        if (explosion)
        {
            Explode();
        }
        GainScore();
        Destroy(gameObject);
    }

    private void Explode()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }

    private void GainScore()
    {
        GameManager.score += score;
    }
}
