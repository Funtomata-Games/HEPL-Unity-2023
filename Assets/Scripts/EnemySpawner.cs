using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public float maxDeviation = 4.5f;
    public float spawnInterval = 0.2f;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), 1f, spawnInterval);
    }

    private void Spawn()
    {
        var deviation = Random.Range(-maxDeviation, maxDeviation);
        var offset = new Vector3(0, deviation);
        var spawnPosition = transform.position + offset;
        Instantiate(enemyToSpawn, spawnPosition, Quaternion.identity);
    }
}
