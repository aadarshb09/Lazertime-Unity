using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroybullet : MonoBehaviour
{
    // Start is called before the first frame update
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

