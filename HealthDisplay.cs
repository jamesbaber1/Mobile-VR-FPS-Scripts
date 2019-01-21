using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class HealthDisplay: MonoBehaviour
{

    //[SerializeField] private string loadlevel;
    [SerializeField]
    public float playerHealth = 100f;
    public float healthUpdate;
    public AudioSource heart;
    public AudioSource breathing;
   // public GameObject death;
    //public GameObject fadesource;
    //public DeathAni fade;
    public static bool dead;
    public bool deadswitch = false;

    public CanvasRenderer bloodScreen;
  

    Vector3 center;

    public void Awake()
    {
        //dead = true;
    }

    public void Start()
    {
        breathing.volume = 0f;
        heart.volume = 0f;
              
        dead = false;
        bloodScreen.SetAlpha(0);

        //dead = true;

        //fade.Start();
        //death.SetActive(false);


    }
   

    void Health(float increment)
    {

        //CanvasGroup canvasgroup = GetComponent<CanvasGroup>();
        //canvasgroup.alpha = increment; //health.test;
        bloodScreen.SetAlpha(increment);
        breathing.volume = increment;
        heart.volume = increment;
    }

    public bool Update()
    {
        return dead;
    }

    public void OnTriggerEnter(Collider col)
    {
       

        if (col.gameObject.name == "tracerZero(Clone)")
        {

            playerHealth -= 1f;
            Health(10f/ playerHealth);

            if (playerHealth <= 0 )
            {

                //dead = true;
                //DeathAni fade = fadesource.GetComponent<DeathAni>();
                //fade.Die();
                //Instantiate(death, transform.position, transform.rotation);
				StartCoroutine(wait());
                //SceneManager.LoadScene(3);
            }


        }

        
       

    }






    IEnumerator wait()
    {
		dead = true;
		yield return new WaitForSeconds (6f);
		SceneManager.LoadScene(3);
    }
}
