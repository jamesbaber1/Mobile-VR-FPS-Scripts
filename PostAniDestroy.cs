using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostAniDestroy : MonoBehaviour {

    public float delay = 0f;

    // Use this for initialization
    private void Start()
    {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length+delay);
    }


}
