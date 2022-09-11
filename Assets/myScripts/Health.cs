using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	//The box's current health point total
	public int currentHealth = 3;
    public GameObject bullet;
    public int damageAmount = 1;
    public Collision BulCo;
    public ParticleSystem expl;
    public int enemyValue;
    private bool hasExploded = false;
    private void Start()
    {
      
    }

    public void OnCollisionEnter(Collision BulCo)
    { 
     
        if (BulCo.gameObject.tag == "bullet")
        {
            currentHealth--;
        }
        
 
    }
    private void Update()
    {
        if (hasExploded == false)
        {
            if (currentHealth == 0)
            {

                Explode();

            }
        }

        
       
        
    }

    public void Explode()
    {
        hasExploded = true;
        var exp = GetComponent<ParticleSystem>();
        var lode = GetComponent<AudioSource>();
        Destroy(this.gameObject, exp.main.duration);
        ScoreText.score += enemyValue;
        
        exp.Play();
        lode.Play();
       
        exp.Play();
    }

}
