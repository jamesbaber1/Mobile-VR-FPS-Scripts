using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTime : MonoBehaviour {


    public float disappear = 3.3f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, disappear);
    }
}
