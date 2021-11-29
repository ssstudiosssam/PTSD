using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void LoadSession1()
    {
        FindObjectOfType<SessionController>().currentSession = 1;
        SceneManager.LoadScene("Intro");
    }

    public void LoadSession2()
    {
        FindObjectOfType<SessionController>().currentSession = 2;
        SceneManager.LoadScene("Sadness");
    }

    public void LoadSession3()
    {
        FindObjectOfType<SessionController>().currentSession = 3;
        SceneManager.LoadScene("Fear");
    }

    public void LoadSession4()
    {
        FindObjectOfType<SessionController>().currentSession = 4;
        SceneManager.LoadScene("Anger");
    }

    public void LoadSession5()
    {
        FindObjectOfType<SessionController>().currentSession = 5;
        SceneManager.LoadScene("Frustration");
    }
}
