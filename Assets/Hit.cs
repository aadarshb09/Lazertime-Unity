/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Collider coll;
    public GameObject bullet;
   
 
    public void OnTriggerEnter(Collider coll)
    {
        if (gameObject.tag == "enemy")
        {
           
             GetComponent<Health>();
            Health.currentHealth--;
            
        }
        Destroy(bullet.gameObject);
    }
}
*/