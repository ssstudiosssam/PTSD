using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearController : MonoBehaviour
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
        FindObjectOfType<AudioController>().Play("Fear01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + PauseTime);
    }

    void PlayAudio2()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio3", waitTime + PauseTime);
    }

    void PlayAudio3()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio4", waitTime + PauseTime);
    }

    void PlayAudio4()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio5", waitTime + PauseTime);
    }

    void PlayAudio5()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear05");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio6", waitTime + PauseTime);
    }

    void PlayAudio6()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear06");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear06");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio7", waitTime + PauseTime);
    }

    void PlayAudio7()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear07");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear07");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio8", waitTime + PauseTime);
    }

    void PlayAudio8()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear08");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear08");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio9", waitTime + PauseTime);
    }

    void PlayAudio9()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear09");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear09");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio10", waitTime + PauseTime);
    }

    void PlayAudio10()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear10");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear10");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio11", waitTime + PauseTime);
    }

    void PlayAudio11()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear11");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear11");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio12", waitTime + PauseTime);
    }

    void PlayAudio12()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear12");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear12");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio13", waitTime + PauseTime);
    }

    void PlayAudio13()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear13");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear13");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio14", waitTime + PauseTime);
    }

    void PlayAudio14()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear14");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear14");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio15", waitTime + PauseTime);
    }

    void PlayAudio15()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear15");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear15");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio16", waitTime + PauseTime);
    }

    void PlayAudio16()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear16");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear16");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio17", waitTime + PauseTime);
    }

    void PlayAudio17()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear17");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear17");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio18", waitTime + PauseTime);
    }

    void PlayAudio18()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear18");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear18");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio19", waitTime + PauseTime);
    }

    void PlayAudio19()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Fear19");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Fear19");

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
