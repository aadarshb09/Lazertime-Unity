using UnityEngine;
using System.Collections;

public class shootBullet : MonoBehaviour
{
    
    public GameObject bulletEmitter;

   
    public Rigidbody bullet;

    
    public float bulletForce;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var lasershot = GetComponent<AudioSource>();
            lasershot.Play();
            GameObject tempBullet;
            tempBullet = (Rigidbody) Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
            //push bullet
            tempBullet.AddForce(transform.forward * bulletForce);
            Destroy(tempBullet, 1.0f);
        }
    }
}
