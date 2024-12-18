using UnityEngine;

public class MoveBackward : MonoBehaviour
{

    public float speed = 5f;

    void Update()
    {
        // Gerakkan GameObject ke arah backward (mundur)
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}