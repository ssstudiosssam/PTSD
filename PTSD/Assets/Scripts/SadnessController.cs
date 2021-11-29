using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadnessController : MonoBehaviour
{

    private float PauseTime = 5f;

    public GameObject scoreController;

    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject ContinueHolder;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayAudio1", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAudio1()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + PauseTime);
    }

    void PlayAudio2()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio3", waitTime + PauseTime);
    }

    void PlayAudio3()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio4", waitTime + PauseTime);
    }

    void PlayAudio4()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio5", waitTime + PauseTime);
    }

    void PlayAudio5()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad05");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio6", waitTime + PauseTime);
    }

    void PlayAudio6()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad06");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad06");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio7", waitTime + PauseTime);
    }

    void PlayAudio7()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad07");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad07");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio8", waitTime + PauseTime);
    }

    void PlayAudio8()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad08");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad08");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio9", waitTime + PauseTime);
    }

    void PlayAudio9()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad09");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad09");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio10", waitTime + PauseTime);
    }

    void PlayAudio10()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad10");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad10");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio11", waitTime + PauseTime);
    }

    void PlayAudio11()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad11");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad11");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio12", waitTime + PauseTime);
    }

    void PlayAudio12()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad12");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad12");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio13", waitTime + PauseTime);
    }

    void PlayAudio13()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad13");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad13");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio14", waitTime + PauseTime);
    }

    void PlayAudio14()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad14");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad14");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio15", waitTime + PauseTime);
    }

    void PlayAudio15()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad15");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad15");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio16", waitTime + PauseTime);
    }

    void PlayAudio16()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Sad16");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Sad16");

        Invoke("StopPandyTalking", waitTime);
        Invoke("End", waitTime + PauseTime);
    }

    void StopPandyTalking()
    {
        //Stop Pandy talking animation
    }

    void End()
    {
        scoreController.SetActive(true);

        sc.SetUpModule1();

        fireWorks.SetActive(true);

        Invoke("ShowContinue", PauseTime);
    }

    void ShowContinue()
    {
        ContinueHolder.SetActive(true);
    }

    void StartPandyTalking()
    {
        //Start Pandy talking animation
    }
}
