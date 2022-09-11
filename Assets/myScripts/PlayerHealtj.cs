using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealtj : MonoBehaviour
{

    //The box's current health point total
    
    public GameObject enbullet;
    public Collider enbulletCOLL;
    //public AudioSource hurt;


    public void OnTriggerEnter(Collider enbulletCOLL)
    {
      
          HealthText.playerHealth--;
        Destroy(enbullet);

    }


    private void Update()
    {
        {
            if (HealthText.playerHealth <= 0)
            {
                HealthText.playerHealth = 50;
                SceneManager.LoadScene("GameOver");
            }

        }
    }


}
