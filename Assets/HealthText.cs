using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public static int playerHealth = 50;
    TextMesh healthText;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health:" + playerHealth;
    }
}