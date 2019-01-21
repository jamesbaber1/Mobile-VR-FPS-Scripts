using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIturretTrack : MonoBehaviour {

    public Vector3 ShakeSize = new Vector3(5f, 5f, 5f);
    public float turnRate = 5f;
    public float speed = 1f;
    private float selector = 0f;
    public Transform TrackerObject1;
    float x;
    float z;
    public float spread = 200f;
    Vector3 randposition;


    //Vector3 rotlock;

    // Use this for initialization
    void Start () {

        StartCoroutine(Tasks());
    }
	
    void Update()
    {

        
            Vector3 direction = randposition - transform.localPosition;
            Quaternion rotation = Quaternion.LookRotation(direction);
            //rotlock = new Vector3(0f, transform.rotation.x, 0f);

            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);

            transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
        

        

    }

    IEnumerator Tasks()
    {
        while (0 < 1)
        {
            //TrackerObject1.transform.position(Mathf.Cos(Random.value) * ShakeSize.x, 0, Mathf.Cos(Random.value) * ShakeSize.z);
            yield return new WaitForSeconds(turnRate);
            x = Random.Range(Random.Range(-spread, -6f), Random.Range(6f, spread));
            z = Random.Range(Random.Range(-spread, -6f), Random.Range(6f, spread));
            randposition = new Vector3(x, 0f, z);


            
        }
    }
}
