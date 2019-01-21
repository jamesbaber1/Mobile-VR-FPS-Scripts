using UnityEngine;

public class BloodAni : MonoBehaviour
{
    void Update()
    {
        Camera cam = Camera.main;

        float pos = (cam.nearClipPlane + 0.01f);

        transform.position = cam.transform.position + cam.transform.forward * pos;

        float h = Mathf.Tan(cam.fieldOfView * Mathf.Deg2Rad * 1f) * pos * cam.aspect;

        transform.localScale = new Vector3(2*(h), 2*h, 3f);
    }

    //cam.aspect
}