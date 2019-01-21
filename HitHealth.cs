using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitHealth: MonoBehaviour
{

  
    public Vector3 ShakeSize = new Vector3(0.01f, 0.01f, 0.01f);
    public float duration = 15f;
    private Vector3 posInitial;

       // Use this for initialization
    void Start()
    {

        posInitial = transform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "tracerZero(Clone)")
        {
            
            StartCoroutine(Shake());
            
        }


    }

    IEnumerator Shake()
    {
        int count = 0;
        while (count < duration)
        {
            transform.Translate(Mathf.Cos(Random.value) * ShakeSize.x, Mathf.Cos(Random.value) * ShakeSize.y, Mathf.Cos(Random.value) * ShakeSize.z);
            ShakeSize *= -1;
            yield return new WaitForSeconds(0.02f);
            count++;

        }
        transform.localPosition = posInitial;


    }

    
  


}
