using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 5f;
    private bool isSpawning = true;

    void Start()
    {
        StartCoroutine(SpawnEnemiesWithDelay());
    }

    IEnumerator SpawnEnemiesWithDelay()
    {
        while (isSpawning)
        {

            float spawnDelay = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnDelay);

            SpawnEnemyAtRandomPoint();
        }
    }

    void SpawnEnemyAtRandomPoint()
    {

        if (spawnPoints.Length > 0 && enemyPrefabs.Length > 0)
        {

            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogWarning("Spawn Points atau Enemy Prefabs belum di-assign.");
        }
    }


    public void StopSpawning()
    {
        isSpawning = false;
    }
}
