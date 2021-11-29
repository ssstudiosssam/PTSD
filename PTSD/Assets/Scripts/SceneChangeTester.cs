using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (FindObjectOfType<SessionController>().currentSession == 1)
            {
                SceneManager.LoadScene("CubeMatch");
            }

            if (FindObjectOfType<SessionController>().currentSession == 2)
            {
                SceneManager.LoadScene("Flashlight");
            }

            if (FindObjectOfType<SessionController>().currentSession == 3)
            {
                //GAME NOT DECIDED YET
                SceneManager.LoadScene("CubeMatch");
            }

            if (FindObjectOfType<SessionController>().currentSession == 4)
            {
                SceneManager.LoadScene("CubeBuild");
            }

            if (FindObjectOfType<SessionController>().currentSession == 5)
            {
                SceneManager.LoadScene("CubeDodge");
            }
        }
    }
}
