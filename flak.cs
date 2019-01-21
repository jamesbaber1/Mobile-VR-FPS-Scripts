using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flak : MonoBehaviour {

    private bool canFade;
    private Color alphaColor;
    private float timeToFade = .1f;
    public float seconds = 2f;
    public float speed = 5f;
    public float moitionspeed = .3f;
    public Transform trackerObject;

    public void Start()
    {
        canFade = false;
        alphaColor = this.GetComponent<MeshRenderer>().material.color;
        alphaColor.a = 0;
        StartCoroutine(Hold(seconds));
    }
    public void Update()
    {
        if (canFade)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.Lerp(this.GetComponent<MeshRenderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
        }
        Vector3 direction = trackerObject.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(-direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        transform.Translate(moitionspeed,0, 0);

    }

    IEnumerator Hold(float seconds)
    {

       yield return new WaitForSeconds(seconds);
       canFade = true;
       yield return new WaitForSeconds(seconds*4);
        Destroy(gameObject);



    }
}
