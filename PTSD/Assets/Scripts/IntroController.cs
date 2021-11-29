using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroController : MonoBehaviour
{

    public GameObject ContinueHolder;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayIntro", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayIntro()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("Intro");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Intro");

        Invoke("ShowContinue", waitTime + 5f);
        Invoke("StopPandyTalking", waitTime);
    }

    private void ShowContinue()
    {
        ContinueHolder.SetActive(true);
    }

    void StopPandyTalking()
    {
        //Stop Pandy talking animation
    }

    void StartPandyTalking()
    {
        //Start Pandy talking animation
    }
}
