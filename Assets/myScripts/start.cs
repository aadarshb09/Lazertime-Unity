﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class start : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet" && SceneManager.GetActiveScene().name == "START"){

            SceneManager.LoadScene("N");
    }
        else if (other.gameObject.tag == "bullet")
        {
            SceneManager.LoadScene("START");
        }
    }
}
