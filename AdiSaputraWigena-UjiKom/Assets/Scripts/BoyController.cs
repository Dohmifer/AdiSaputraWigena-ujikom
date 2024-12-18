using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Animator anim;

    public GameObject projectile;
    public Transform spawnProjectile;
    public float projectileSpeed = 5f;




    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBase();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Shoot();
        }
    }

    public void MoveBase()
    {

        float mHorizontal = Input.GetAxis("Horizontal");
        //Debug.Log(Input.GetAxis("Horizontal"));

        Vector2 move = new Vector2(mHorizontal, rb.velocity.y);

        rb.velocity = move * speed;

    }

    void Shoot()
    {
        GameObject fire = Instantiate(projectile, spawnProjectile.position, Quaternion.identity); //instantiate summon
        Rigidbody rBFire = fire.GetComponent<Rigidbody>();

        rBFire.velocity = transform.forward * projectileSpeed * Time.deltaTime;
    }



}
