using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runner : MonoBehaviour
{
    public Collider playerCol;

    private bool justHit = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    private void OnTriggerEnter(Collider playerCol)
    {
        if (playerCol.gameObject.tag == "MainCamera" && justHit == false) {
           var ouch = GetComponent<AudioSource>();
            HealthText.playerHealth--;
            ouch.Play();
            justHit = true;
            new WaitForSeconds(3f);
            justHit = false;
        }
    }
}
