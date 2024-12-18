using UnityEngine;

public class EnemyCollisionHandler : MonoBehaviour
{
    private ScoreManager scoreManager; // Referensi ke ScoreManager

    private void Start()
    {
        // Cari ScoreManager di scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Periksa apakah bersentuhan dengan GameObject yang memiliki tag "Wall"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Kurangi skor melalui ScoreManager jika ditemukan
            if (scoreManager != null)
            {
                //scoreManager.SubtractScore(1);
            }

            // Opsional: Hancurkan enemy setelah menabrak dinding
            Destroy(gameObject);
        }
    }
}