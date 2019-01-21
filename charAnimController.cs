using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charAnimController : MonoBehaviour {

	public Animator anim;
	public Quaternion prevRot;
	public Camera cam;
    public float ydirection;
    public float xdirection;
    public AudioSource hydrolock;
    public AudioSource hydrolics;
    public Vector3 ShakeSize = new Vector3(0.01f, 0.01f, 0.01f);
    public float duration = 5f;
    public GameObject turret;


    private bool flip = false;


    // Use this for initialization
    void Start () {
		anim = GetComponent<Animator> ();

        if (flip == true)
       {
            hydrolock.Play();
            StartCoroutine(Shake());
        }
    }
	
	// Update is called once per frame
	void Update () {

		Vector3 rotVect = cam.transform.rotation.eulerAngles - prevRot.eulerAngles;

        //Debug.Log (rotVect);

        anim.SetFloat("horiz_motion", rotVect.y);

        ydirection = rotVect.y;
        xdirection = rotVect.x;

        if (ydirection < -0.15f || ydirection > 0.15f || xdirection < -0.15f || xdirection > 0.15f)
        {
            hydrolics.volume = 1f;
            flip = true;
        }

        else if (ydirection == 0 && xdirection == 0 && flip == true)
        {
            Start();
            flip = false;

        }

        else
        {
            hydrolics.volume = 0f;
            flip = false;
        }



        prevRot = cam.transform.rotation;


	}

    void LockSound()
    {
        Start();
    }

    IEnumerator Shake()
    {
        int count = 0;
        while (count < duration)
        {
            turret.transform.Translate(Mathf.Cos(Random.value) * ShakeSize.x, Mathf.Cos(Random.value) * ShakeSize.y, Mathf.Cos(Random.value) * ShakeSize.z);
            ShakeSize *= -1;
            yield return new WaitForSeconds(0.1f);
            count++;

        }
    }
}
