using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet" || other.gameObject.tag == "playerbullet")
        {
            Destroy(other);
        }

    }
}
