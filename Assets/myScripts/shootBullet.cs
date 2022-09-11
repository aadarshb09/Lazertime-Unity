using UnityEngine;
using System.Collections;

public class shootBullet : MonoBehaviour
{
    
    public GameObject bulletEmitter;

   
    public GameObject bullet;

    
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
            tempBullet = (GameObject) Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);

            
            //Correct rotation
            tempBullet.transform.Rotate(Vector3.left * 90);

            //get rigidbody from the new Bullet
            Rigidbody tempRigidbody;
            tempRigidbody = tempBullet.GetComponent<Rigidbody>();

            //push bullet

            Temporary_RigidBody.AddForce(transform.forward * bulletForce);

            Destroy(Temporary_Bullet_Handler, 10.0f);
        }
    }
}
