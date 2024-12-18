using UnityEngine;

public class EnemyCollisionHandler : MonoBehaviour
{
    private ScoreManager scoreManager; 

    private void Start()
    {
        // Cari ScoreManager di scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            


            
            Destroy(gameObject);
        }
    }
}