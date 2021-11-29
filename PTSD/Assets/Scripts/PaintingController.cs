using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaintingController : MonoBehaviour
{

    private float PauseTime = 5f;

    public GameObject scoreController;

    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject ContinueHolder;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayAudio1", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAudio1()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("AT01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("AT01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + PauseTime);
    }

    void PlayAudio2()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("AT02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("AT02");

        Invoke("StopPandyTalking", waitTime);
        ContinueHolder.SetActive(true);
    }

    public void EndPainting()
    {
        ContinueHolder.SetActive(false);

        scoreController.SetActive(true);

        sc.SetUpModule5();

        fireWorks.SetActive(true);

        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("AT03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("AT03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("NextInstruction", waitTime + PauseTime);
    }

    void NextInstruction()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("AT04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("AT04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("GoToNextScene", waitTime + PauseTime);
    }

    void GoToNextScene()
    {
        if (FindObjectOfType<SessionController>().currentSession == 5)
        {
            SceneManager.LoadScene("Conclusion");
        }
        else
        {
            SceneManager.LoadScene("End");
        }
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
