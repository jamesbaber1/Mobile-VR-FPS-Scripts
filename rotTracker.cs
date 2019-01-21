using UnityEngine;

public class rotTracker : MonoBehaviour {

    public float speed = 5f;
    public Transform activeTrackerObject;
    public Transform InactiveTrackerObject;


    private void Update()
    {
        if (activeTrackerObject.position.y >= 4f)
        {
            Vector3 direction = InactiveTrackerObject.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        }

        if (activeTrackerObject.position.y < 4f)
        {
            Vector3 direction = activeTrackerObject.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);
        }
    }
}
