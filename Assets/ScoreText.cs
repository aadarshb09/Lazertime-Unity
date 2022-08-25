using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    [SerializeField]
    public static int score = 0;
    TextMesh scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE:" + score;
        if(score >= 6000 && SceneManager.GetActiveScene().name =="MAIN")
        {
            score = 0;
            SceneManager.LoadScene("Win");
        }
    }
}
