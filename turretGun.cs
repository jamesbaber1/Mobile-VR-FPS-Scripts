using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretGun : MonoBehaviour {

    public float damage = 10f;
    public float range = 200f;
    public ParticleSystem muzzleFlashRight;
    public ParticleSystem muzzleFlashLeft;
    public Camera fpsCam;
    private bool firing = false;
    public float fRate = 0.3f;
    public Vector3 ShakeSize = new Vector3(0.01f, 0.01f, 0.01f);
    public float duration = 15f;
    private Vector3 posInitial;
    public GameObject ObjectToShake;

    // Update is called once per frame


    void Start()
    {

        posInitial = ObjectToShake.transform.localPosition;

    }

    void Update()
    {

        
        if (Input.GetMouseButtonDown(0))
        {
            firing = true;
            StartCoroutine(Shoot(fRate));
        }

        if (Input.GetMouseButtonUp(0))
        {
            firing = false;
        }

    }

    IEnumerator Shoot(float seconds)
    {
        while (firing)
        {
            muzzleFlashRight.Play();
            muzzleFlashLeft.Play();
            
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {


                enemy planeZero = hit.transform.GetComponent<enemy>();

                if (planeZero != null)
                {
                    planeZero.TakeDamage(damage);
                }
            }

            int count = 0;
            while (count < duration)
            {
                ObjectToShake.transform.Translate(Mathf.Cos(Random.value) * ShakeSize.x, Mathf.Cos(Random.value) * ShakeSize.y, Mathf.Cos(Random.value) * ShakeSize.z);
                ShakeSize *= -1;
                yield return new WaitForSeconds(0.02f);
                count++;

            }
            ObjectToShake.transform.localPosition = posInitial;

            yield return new WaitForSeconds(seconds);
            
        }


    }

    //void OnTriggerEnter(Collider col)
    //{ 
    
    //    if (col.gameObject.name == "zero_blend_propellor_spin")
    //    {
    //        enemy planeZero = enemy.GetComponent<enemy>();

    //        GameObject thePlayer = GameObject.Find("ThePlayer");
    //        enemy playerScript = enemy.GetComponent<enemy>();

            

    //        if (planeZero != null)
    //            {
    //                planeZero.TakeDamage(damage);
    //            }
    //    }
    //}

 
}
