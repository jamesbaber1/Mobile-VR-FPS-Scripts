using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour {

    public void changeScene()
    {
        Application.Quit();
    }


    IEnumerator fade()
    {

        float fadeTime = GameObject.Find("Fade").GetComponent<Fading>().beginFade(1);
        yield return new WaitForSeconds(fadeTime);

    }
}
