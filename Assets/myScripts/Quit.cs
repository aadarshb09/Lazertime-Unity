using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {

            Application.Quit();
            Debug.Log("Quit");
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
