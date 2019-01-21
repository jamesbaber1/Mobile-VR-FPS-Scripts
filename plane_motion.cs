using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_motion : MonoBehaviour {

    public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, -speed);
        Destroy(gameObject, 15f);

    }
}
