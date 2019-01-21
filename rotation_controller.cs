using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_controller : MonoBehaviour {

	public float speed= .1f;


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {


		transform.rotation = Quaternion.Euler(-23.562f, transform.rotation.eulerAngles.y, 0);

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, (-speed), 0);
		} 

		else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, speed, 0);
		} 
			

	}
}