using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerController : MonoBehaviour
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
        FindObjectOfType<AudioController>().Play("Anger01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + PauseTime);
    }

    void PlayAudio2()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio3", waitTime + PauseTime);
    }

    void PlayAudio3()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio4", waitTime + PauseTime);
    }

    void PlayAudio4()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio5", waitTime + PauseTime);
    }

    void PlayAudio5()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger05");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio6", waitTime + PauseTime);
    }

    void PlayAudio6()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger06");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger06");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio7", waitTime + PauseTime);
    }

    void PlayAudio7()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger07");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger07");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio8", waitTime + PauseTime);
    }

    void PlayAudio8()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger08");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger08");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio9", waitTime + PauseTime);
    }

    void PlayAudio9()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger09");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger09");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio10", waitTime + PauseTime);
    }

    void PlayAudio10()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger10");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger10");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio11", waitTime + PauseTime);
    }

    void PlayAudio11()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger11");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger11");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio12", waitTime + PauseTime);
    }

    void PlayAudio12()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger12");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger12");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio13", waitTime + PauseTime);
    }

    void PlayAudio13()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger13");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger13");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio14", waitTime + PauseTime);
    }

    void PlayAudio14()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger14");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger14");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio15", waitTime + PauseTime);
    }

    void PlayAudio15()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger15");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger15");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio16", waitTime + PauseTime);
    }

    void PlayAudio16()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger16");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger16");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio17", waitTime + PauseTime);
    }

    void PlayAudio17()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger17");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger17");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio18", waitTime + PauseTime);
    }

    void PlayAudio18()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger18");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger18");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio19", waitTime + PauseTime);
    }

    void PlayAudio19()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger19");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger19");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio20", waitTime + PauseTime);
    }

    void PlayAudio20()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger20");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger20");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio21", waitTime + PauseTime);
    }

    void PlayAudio21()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger21");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger21");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio22", waitTime + PauseTime);
    }

    void PlayAudio22()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Anger22");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Anger22");

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
