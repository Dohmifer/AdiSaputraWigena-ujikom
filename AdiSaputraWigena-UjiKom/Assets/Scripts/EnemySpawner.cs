using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Array Transform untuk titik spawn
    public Transform[] spawnPoints;

    // Array GameObject untuk prefabs enemy
    public GameObject[] enemyPrefabs;

    // Jumlah enemy yang ingin di-spawn sekaligus
    public int enemiesToSpawn = 1;

    // Fungsi ini akan dipanggil dari Animation Event
    void Update()
    {
        SpawnEnemies();
    }
    public void SpawnEnemies()
    {
        // Memeriksa apakah spawnPoints dan enemyPrefabs memiliki elemen
        if (spawnPoints.Length > 0 && enemyPrefabs.Length > 0)
        {
            // Loop untuk spawn lebih dari satu enemy
            for (int i = 0; i < enemiesToSpawn; i++)
            {
                // Pilih spawn point secara acak
                Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

                // Pilih prefab enemy secara acak
                GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

                // Spawn enemy pada spawn point
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            }
        }
        else
        {
            Debug.LogWarning("Spawn Points atau Enemy Prefabs belum di-assign.");
        }
    }

}
