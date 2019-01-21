using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class quitESC : MonoBehaviour
{
  
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
        }

    }
}
