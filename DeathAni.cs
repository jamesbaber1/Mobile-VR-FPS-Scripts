using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAni : MonoBehaviour
{
    [SerializeField]
    public Animator fade;
    public AudioSource die;
    public GameObject PlanesSpawner;
    public GameObject FlakSpawner;
    public GameObject AITurret1;
    public GameObject AITurret2;
    //public GameObject deathSound;
	public GameObject UI;
    public float playerHealth = 100f;
    private AudioSource[] allAudioSources;
    public HealthDisplay Player;
    public GameObject UI2;
    bool temp;
    int count = 0;


    // public HealthDisplay health;

    
    void Start()
    {
        //Player = GetComponent<HealthDisplay>();
        fade = GetComponent<Animator>();
        fade.SetBool("death", false);
    }
    public void Update()
    {
        if (count == 0)
        {
            temp = Player.Update();
        }

        
        if (temp)
       {
            Die();
            temp = false;
            count = 1;
            //fade.SetBool("death", true);
            //PlanesSpawner.SetActive(false);
            //FlakSpawner.SetActive(false); ;
            //AITurret1.SetActive(false);
            //AITurret2.SetActive(false);
            //StopAllAudio();
            //die.Play();

        }
    }

    


    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }


    public void Die()
    {

        
        fade.SetBool("death", true);
        PlanesSpawner.SetActive(false);
        FlakSpawner.SetActive(false); ;
        AITurret1.SetActive(false);
        AITurret2.SetActive(false);
		UI.SetActive(false);
        UI2.SetActive(false);
        StopAllAudio();
        die.Play();

    }
}


//health.playerHealth <= 0)


