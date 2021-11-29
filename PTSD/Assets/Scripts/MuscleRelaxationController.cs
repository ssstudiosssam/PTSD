using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuscleRelaxationController : MonoBehaviour
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
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + PauseTime);
    }

    void PlayAudio2()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio3", waitTime + PauseTime);
    }

    void PlayAudio3()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio4", waitTime + PauseTime);
    }

    void PlayAudio4()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio5", waitTime + PauseTime);
    }

    void PlayAudio5()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc05");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio6", waitTime + PauseTime);
    }

    void PlayAudio6()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc06");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc06");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio7", waitTime + PauseTime);
    }

    void PlayAudio7()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc07");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc07");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio8", waitTime + PauseTime);
    }

    void PlayAudio8()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc08");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc08");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio9", waitTime + PauseTime);
    }

    void PlayAudio9()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc09");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc09");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio10", waitTime + PauseTime);
    }

    void PlayAudio10()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc10");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc10");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio11", waitTime + PauseTime);
    }

    void PlayAudio11()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc11");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc11");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio12", waitTime + PauseTime);
    }

    void PlayAudio12()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc12");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc12");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio13", waitTime + PauseTime);
    }

    void PlayAudio13()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc13");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc13");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio14", waitTime + PauseTime);
    }

    void PlayAudio14()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc14");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc14");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio15", waitTime + PauseTime);
    }

    void PlayAudio15()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc15");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc15");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio16", waitTime + PauseTime);
    }

    void PlayAudio16()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc16");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc16");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio17", waitTime + PauseTime);
    }

    void PlayAudio17()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc17");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc17");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio18", waitTime + PauseTime);
    }

    void PlayAudio18()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc18");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc18");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio19", waitTime + PauseTime);
    }

    void PlayAudio19()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc19");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc19");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio20", waitTime + PauseTime);
    }

    void PlayAudio20()
    {
        //Start appropriate animation

        FindObjectOfType<AudioController>().Play("Musc20");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Musc20");

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

        sc.SetUpModule3();

        fireWorks.SetActive(true);

        Invoke("ShowContinue", PauseTime);
    }

    void ShowContinue()
    {
        ContinueHolder.SetActive(true);
    }
}
