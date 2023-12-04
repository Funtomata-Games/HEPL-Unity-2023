using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyToSpawn;
    public float spawnInterval = 0.2f;
    public float maxOffset = 4.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1, spawnInterval);
    }
    
    void Spawn()
    {
        var spawnType = Random.Range(0, enemyToSpawn.Length);
        var deviation = Random.Range(-maxOffset, maxOffset);
        var spawnPosition = transform.position + new Vector3(0, deviation);
        Instantiate(enemyToSpawn[spawnType], spawnPosition, Quaternion.identity);
    }
}
