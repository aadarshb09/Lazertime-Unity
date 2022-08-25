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
        if(SceneManager.GetActiveScene().name != "START" && SceneManager.GetActiveScene().name != "GameOver" && SceneManager.GetActiveScene().name != "Win")
        StartCoroutine(waitbullet());
       

    }
    IEnumerator waitbullet()
    {
        yield return new WaitForSeconds(.005f);
        Destroy(gameObject);




    }
}

