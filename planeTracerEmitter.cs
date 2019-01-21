using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeTracerEmitter : MonoBehaviour {

    public GameObject tracer;
    public AudioSource gun;

    public float rate = 0.1f;
    public float pause = 5f;
    private float trackspeed = 5f;
    public float difficulty = .5f;
    public Transform trackerObject;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Tasks());
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = trackerObject.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, trackspeed * Time.deltaTime);
    }

    IEnumerator Tasks()
        {
            while (0 < 1)
            {
                yield return new WaitForSeconds(pause);
                gun.Play();
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(rate);
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(rate);
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(rate);
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(rate);
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(rate);
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(rate);
                Instantiate(tracer, transform.position, transform.rotation);
                
                trackspeed += difficulty;
        }
        }
}
