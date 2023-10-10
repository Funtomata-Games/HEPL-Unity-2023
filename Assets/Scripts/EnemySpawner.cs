using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float maxSpreadDistance;
    public float spawnInterval;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnInterval, spawnInterval);
    }

    void Spawn()
    {
        var spreadDistance = Random.Range(-maxSpreadDistance, maxSpreadDistance);
        var spawnPosition = transform.position + new Vector3(0, spreadDistance);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
    

}
