using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Animator anim;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBase();
    }

    public void MoveBase()
    {
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float move = rb.velocity.x;
        // move = transform.Translate(transform.position.x * speed, transform.position.y, transform.position.z);

        // if(moveHorizontal >= 0)
        // {

        // }
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        float speed = 5.0f;
        transform.position = new Vector3(horizontal, 0, 0) * speed * Time.deltaTime;
    }

}
