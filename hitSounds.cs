using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitSounds : MonoBehaviour {


    public AudioSource hit1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "tracerZero")
        {
            hit1.Play();

        }
    }
}
