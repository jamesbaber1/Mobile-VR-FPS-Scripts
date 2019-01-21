using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turrentRotation : MonoBehaviour
{

    //public Transform target;


    float lockPos = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(Mathf.Clamp(transform.rotation.eulerAngles.x, 0f, 90f), transform.rotation.eulerAngles.y, lockPos);
    }
}
//