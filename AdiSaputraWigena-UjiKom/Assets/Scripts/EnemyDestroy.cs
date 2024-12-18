using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Projectile"))
        {

            Destroy(gameObject);


            Destroy(collision.gameObject);
        }
    }
}
