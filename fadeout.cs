using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{

   
    private bool canFade;
    private Color alphaColor;
    private float timeToFade = 1.0f;

    public void Start()
    {
        canFade = true;
        alphaColor = this.GetComponent<MeshRenderer>().material.color;
        alphaColor.a = 0;
    }
    public void Update()
    {
        if (canFade)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.Lerp(this.GetComponent<MeshRenderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
        }
    }

    //IEnumerator Hold(float seconds)
    //{

    //    yield return new WaitForSeconds(seconds);


    //    getComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
    //}




}