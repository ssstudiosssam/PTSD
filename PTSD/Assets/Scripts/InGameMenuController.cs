using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuController : MonoBehaviour
{

    public GameObject menu;
    public bool menuOpen;

    public string thisSceneName;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            if (menuOpen == false)
            {
                menu.SetActive(true);
                menuOpen = true;
            }
            else
            {
                menu.SetActive(false);
                menuOpen = false;
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            if (menuOpen == true)
            {
                SceneManager.LoadScene(thisSceneName);
            }
        }

        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (menuOpen == true)
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
}
