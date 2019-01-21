using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flakSpawner : MonoBehaviour {

    public GameObject flak1;
    public GameObject flak2;
    public GameObject flak3;
    public GameObject flak4;
    public GameObject flak5;
    public GameObject flak6;
    public GameObject flak7;
    public GameObject flak8;
    float x;
    float y;
    float z;
    Vector3 randposition;
    public float spawnRate = 15f;
    public float spread = 200f;
    int selector;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(Tasks());
    }


    IEnumerator Tasks()
    {
        while (0 < 1)
        {
            selector = (int)Random.Range(0f, 7.9f) / 1;


            if (selector == 0)
            {
                createFlak(flak1);

            }

            if (selector == 1)
            {
                createFlak(flak2);

            }

            if (selector == 2)
            {
                createFlak(flak3);

            }

            if (selector == 3)
            {
                createFlak(flak4);

            }

            if (selector == 4)
            {
                createFlak(flak5);

            }

            if (selector == 5)
            {
                createFlak(flak6);

            }

            if (selector == 6)
            {
                createFlak(flak7);

            }

            if (selector == 7)
            {
                createFlak(flak8);

            }

            yield return new WaitForSeconds(spawnRate);
        }
    }

    void createFlak(GameObject flak)
    {
        
        x = Random.Range(Random.Range(-spread, -6f), Random.Range(6f, spread));
        y = Random.Range(Random.Range(-spread, -6f), Random.Range(6f, spread));
        z = Random.Range(Random.Range(-spread, -6f), Random.Range(6f, spread));
        randposition = new Vector3(x, y, z);
        Instantiate(flak, randposition, transform.rotation);


    }
}

