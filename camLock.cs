using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLock : MonoBehaviour {

    //public Transform target;


    float lockPos = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -10f, -2f), transform.position.z);
       transform.eulerAngles = new Vector3(Mathf.Clamp(transform.eulerAngles.x, 0f, 180f), transform.eulerAngles.y, transform.eulerAngles.z);


        //if (transform.eulerAngles.x >0f)
       // {

      //  }
        //if (transform.position.y == 0)
        //{

            //Vector3 direction = trackerObject.position.y - transform.position.y;
            //Quaternion rotation = Quaternion.LookRotation(direction);
            //transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        //}
    }


    static float ClampAngle(float angle, float min, float max)
    {
        if (min < 0 && max > 0 && (angle > max || angle < min))
        {
            angle -= 360;
            if (angle > max || angle < min)
            {
                if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))) return min;
                else return max;
            }
        }
        else if (min > 0 && (angle > max || angle < min))
        {
            angle += 360;
            if (angle > max || angle < min)
            {
                if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))) return min;
                else return max;
            }
        }

        if (angle < min) return min;
        else if (angle > max) return max;
        else return angle;
    }
}
//Mathf.Clamp(transform.rotation.eulerAngles.x, 0f, -50f)
//Mathf.Clamp(transform.eulerAngles.x, -10f, 190f)
