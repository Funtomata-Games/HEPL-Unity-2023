using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnInterval = 0.5f;
    public float maxSpreadDistance = 4.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnInterval, spawnInterval);
    }

    void Spawn()
    {
        float randomDistance = Random.Range(-maxSpreadDistance, maxSpreadDistance);
        Vector3 spreadDistance = new Vector3(0, randomDistance);
        Vector3 spawnPosition = transform.position + spreadDistance;
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
    
}
