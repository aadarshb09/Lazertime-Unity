using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{

    public Transform player;
    public float range = 50.0f;
    public float bulletImpulse = 20.0f;
    //public AudioSource hurt;

    private bool onRange = false;

    public Rigidbody projectile;

    void Start()
    {
        Shoot();
        float rand = Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 1, rand);
    }

    void Shoot()
    {
        onRange = Vector3.Distance(transform.position, player.position) < range;
        if (onRange)
        {

            Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            bullet.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);

            Destroy(bullet.gameObject, 1);
        }


    }

    void Update()
    {

        onRange = Vector3.Distance(transform.position, player.position) < range;

        if (onRange){
            transform.LookAt(player);

    }

}

    }
