using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    // Array Transform untuk titik spawn
    public Transform[] spawnPoints;

    // Array GameObject untuk prefabs enemy
    public GameObject[] enemyPrefabs;

    // Durasi minimum dan maksimum spawn (dalam detik)
    public float minSpawnTime = 1f;
    public float maxSpawnTime = 5f;

    // Flag untuk mengontrol spawning
    private bool isSpawning = true;

    void Start()
    {
        // Mulai coroutine untuk spawn musuh
        StartCoroutine(SpawnEnemiesWithDelay());
    }

    IEnumerator SpawnEnemiesWithDelay()
    {
        while (isSpawning)
        {
            // Tunggu secara random antara minSpawnTime dan maxSpawnTime
            float spawnDelay = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(spawnDelay);

            // Spawn musuh satu per satu di spawn point acak
            SpawnEnemyAtRandomPoint();
        }
    }

    void SpawnEnemyAtRandomPoint()
    {
        // Periksa apakah ada spawn points dan enemy prefabs
        if (spawnPoints.Length > 0 && enemyPrefabs.Length > 0)
        {
            // Pilih spawn point secara acak
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Pilih prefab enemy secara acak
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

            // Spawn enemy pada spawn point
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogWarning("Spawn Points atau Enemy Prefabs belum di-assign.");
        }
    }

    // Method untuk menghentikan spawning jika diperlukan
    public void StopSpawning()
    {
        isSpawning = false;
    }
}
