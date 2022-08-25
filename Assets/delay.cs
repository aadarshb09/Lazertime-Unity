using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    void Start()
    {
        
            gameObject.SetActive(false);

        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(3f);

        gameObject.SetActive(true);
        //Do Function here...
    }

}
