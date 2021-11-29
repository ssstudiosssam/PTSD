using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappinessController : MonoBehaviour
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
        FindObjectOfType<AudioController>().Play("Hap01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + PauseTime);
    }

    void PlayAudio2()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio3", waitTime + PauseTime);
    }

    void PlayAudio3()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio4", waitTime + PauseTime);
    }

    void PlayAudio4()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio5", waitTime + PauseTime);
    }

    void PlayAudio5()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap05");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio6", waitTime + PauseTime);
    }

    void PlayAudio6()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap06");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap06");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio7", waitTime + PauseTime);
    }

    void PlayAudio7()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap07");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap07");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio8", waitTime + PauseTime);
    }

    void PlayAudio8()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap08");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap08");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio9", waitTime + PauseTime);
    }

    void PlayAudio9()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap09");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap09");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio10", waitTime + PauseTime);
    }

    void PlayAudio10()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap10");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap10");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio11", waitTime + PauseTime);
    }

    void PlayAudio11()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap11");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap11");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio12", waitTime + PauseTime);
    }

    void PlayAudio12()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap12");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap12");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio13", waitTime + PauseTime);
    }

    void PlayAudio13()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap13");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap13");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio14", waitTime + PauseTime);
    }

    void PlayAudio14()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap14");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap14");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio15", waitTime + PauseTime);
    }

    void PlayAudio15()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap15");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap15");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio16", waitTime + PauseTime);
    }

    void PlayAudio16()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Hap16");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Hap16");

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
