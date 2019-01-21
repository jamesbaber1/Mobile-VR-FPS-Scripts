using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camShake : MonoBehaviour {


    public Vector3 ShakeSize = new Vector3(0.01f, 0.01f,0.01f);
    public float duration = 5f;
    private Vector3 posInitial;
    public GameObject ObjectToShake;
    

    void Start()
    {

        posInitial = ObjectToShake.transform.position;
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        int count = 0;
        while (count < duration)
        {
            ObjectToShake.transform.Translate(Mathf.Cos(Random.value) * ShakeSize.x, Mathf.Cos(Random.value) * ShakeSize.y, Mathf.Cos(Random.value) * ShakeSize.z);
            ShakeSize *= -1;
            yield return new WaitForSeconds(0.1f);
            count++;
            
        }
        ObjectToShake.transform.position = posInitial;

    }

}
