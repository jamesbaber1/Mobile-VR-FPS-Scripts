using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    public float DamageToEnenmy = 10f;
    public float health = 10f;
    public GameObject zeroDestoyed1;
    public GameObject zeroDestoyed2;
    public GameObject zeroDestoyed3;
    public int selector;

	[SerializeField]
	public static int kills = 0;
	public static string converter = "0";
	public Text yourscore;
	string killCount = converter;
	public Vector3 intPos;
	public Vector3 finalPos;

	void Start()
	{
		//intPos = new Vector3 (0, 0, 0);
		//finalPos = new Vector3 (0, 0, 0);
		//PlayerPrefs.SetString ("High Score", "5");
	}


    public void TakeDamage(float amount)
    {
        health -= amount;



        if (health <= 0)
        {
			

            selector = (int)Random.Range(0f, 2.9f) / 1;


            if (selector == 0)
            {
                Die1();

            }
            if (selector == 1)
            {
                Die2();

            }
            if (selector == 2)
            {
                Die3();

            }
			zeroKills ();
        }
    }

    void Die1()
    {
        Instantiate(zeroDestoyed1, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void Die2()
    {
        Instantiate(zeroDestoyed2, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void Die3()
    {
        Instantiate(zeroDestoyed3, transform.position, transform.rotation);
        Destroy(gameObject);
    }
		
	public void zeroKills()
	{

		kills = kills + 1; 
		converter = kills.ToString();
		PlayerPrefs.SetInt ("Your Score", kills);

		PlayerPrefs.SetString ("Your Score", converter);

		if (kills > PlayerPrefs.GetInt ("High Score")) 
		{
			PlayerPrefs.SetInt ("High Score", kills);
		}


		//nerds.transform.position = intPos;
		yourscore.text = PlayerPrefs.GetString ("Your Score");
	}
}
