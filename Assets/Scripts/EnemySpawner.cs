using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnInterval = 0.5f;
    public float maxSpreadRange = 4.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnInterval, spawnInterval);
    }

    void Spawn()
    {
        var spread = Random.Range(-maxSpreadRange, maxSpreadRange);
        var spawnPosition = transform.position + new Vector3(0, spread);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
