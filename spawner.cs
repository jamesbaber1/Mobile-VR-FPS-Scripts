using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject spawnZero1;
    public GameObject spawnZero2;
    public GameObject spawnZero3;
    public GameObject spawnZero4;
    public GameObject spawnZero5;
    public GameObject spawnZero6;
    public GameObject spawnZero7;
    public float spawnRate = 15f;
    private int selector =0;

    // Use this for initialization
 void Start()
    {
        StartCoroutine(Tasks());
    }

    
    IEnumerator Tasks()
    {
        while (0 < 1)
        {
            selector = (int)Random.Range(0f, 6f) / 1;


            if (selector == 0)
            {
                spawnEnemy(spawnZero1);
            }

            if (selector == 1)
            {
                spawnEnemy(spawnZero2);
            }

            if (selector == 2)
            {
                spawnEnemy(spawnZero3);
            }
            if (selector == 3)
            {
                spawnEnemy(spawnZero4);
            }

            if (selector == 4)
            {
                spawnEnemy(spawnZero5);
            }

            if (selector == 5)
            {
                spawnEnemy(spawnZero6);
            }

            if (selector == 6)
            {
                spawnEnemy(spawnZero7);
            }

            yield return new WaitForSeconds(spawnRate);

        }
    }


    void spawnEnemy(GameObject Zero)
    {
        Instantiate(Zero, transform.position, transform.rotation);
        
    }
}
