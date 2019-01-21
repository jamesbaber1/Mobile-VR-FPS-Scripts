using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracers : MonoBehaviour {

    public float speed = 1f;
    public AudioSource hit1;
    public AudioSource hit2;
    public AudioSource hit3;
    public AudioSource hit4;
    public AudioSource hit5;
    public AudioSource hit6;
    public AudioSource hit7;
    public AudioSource hit8;
    public AudioSource hit9;
    public AudioSource hit10;
    public AudioSource hit11;
    public AudioSource hit12;
    public AudioSource hit13;
    public AudioSource hit14;
    public GameObject flame;

    public int selector;
    
    void Start()
    {
        
    }


	
	// Update is called once per frame
	void Update () {


        transform.Translate(0, 0, speed);
        Destroy(gameObject, 2f);
        
    }

    void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.name == "turret_asset")
        {
            selector = (int)Random.Range(0f, 13f)/ 1;
            

            if(selector == 0)
            {
                hit1.Play();
                
            }
             if (selector == 1)
            {
                hit2.Play();
               
            }
             if(selector == 2)
            {
                hit3.Play();
                
            }
             if(selector == 3)
            {
                hit4.Play();
                
            }
             if (selector == 4)
            {
                hit5.Play();
                
            }
             if (selector == 5)
            {
                hit6.Play();
                
            }
             if (selector == 6)
            {
                hit7.Play();
                
            }
             if (selector == 7)
            {
                hit8.Play();

            }
             if (selector == 8)
            {
                hit9.Play();

            }
             if (selector == 9)
            {
                hit10.Play();

            }
             if (selector == 10)
            {
                hit11.Play();

            }
             if (selector == 11)
            {
                hit12.Play();

            }
             if (selector == 12)
            {
                hit13.Play();

            }
             if (selector == 13)
            {
                hit14.Play();

            }

            Destroy(flame);

        }
    }

    
}
