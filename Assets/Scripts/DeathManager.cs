using UnityEngine;

public class DeathManager : MonoBehaviour
{
    public GameObject explosion;
    public int score;

    public void Kill()
    {
        GainScore();
        if (explosion) Explode();
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