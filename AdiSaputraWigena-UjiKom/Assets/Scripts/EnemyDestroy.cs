using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    public int scoreValue = 1;
    private ScoreManager scoreManager;

    private void Start()
    {

        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {

            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);
            }


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
