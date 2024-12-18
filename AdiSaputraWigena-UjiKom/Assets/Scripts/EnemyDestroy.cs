using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public int scoreValue = 1; // Nilai skor untuk setiap enemy
    private ScoreManager scoreManager; // Referensi ke ScoreManager

    private void Start()
    {
        // Cari ScoreManager di scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Tambahkan skor melalui ScoreManager
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);
            }

            // Hancurkan enemy dan projectile
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    // private void OnCollisionEnter(Collision collision)
    // {

    //     if (collision.gameObject.CompareTag("Projectile"))
    //     {

    //         Destroy(gameObject);


    //         Destroy(collision.gameObject);
    //     }
    // }
}
