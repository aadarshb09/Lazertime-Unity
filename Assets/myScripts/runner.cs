using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runner : MonoBehaviour
{
    public Collider playerCol;

    private bool justHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    private void OnTriggerEnter(Collider playerCol)
    {
        //checking if collider is really the player's
        if (playerCol.gameObject.tag == "MainCamera" && justHit == false) {
            HealthText.playerHealth--;
            justHit = true;
            new WaitForSeconds(3f);
            justHit = false;
        }
    }
}
