using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroybullet : MonoBehaviour
{
    // destroy player bullet
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
 

    private void OnCollisionEnter(Collision collision)
    {
        if(SceneManager.GetActiveScene().name == "MAIN")
            // StartCoroutine(waitbullet());
            Destroy(gameObject);

    }

}

