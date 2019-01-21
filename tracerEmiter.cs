using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracerEmiter : MonoBehaviour {

    public GameObject tracer;
    private bool firing = false;
    public float fRate = 0.3f;


	// Use this for initialization
	void Start ()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firing = true;
            StartCoroutine(Hold(fRate));
        }

        if (Input.GetMouseButtonUp(0))
        {
            firing = false;
        }
    }

    // Update is called once per frame

    IEnumerator Hold(float seconds)
    {
        while (firing)
        {
                Instantiate(tracer, transform.position, transform.rotation);
                yield return new WaitForSeconds(seconds);

        }
    }
}

