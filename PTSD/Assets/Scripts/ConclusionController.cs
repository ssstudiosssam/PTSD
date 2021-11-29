using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConclusionController : MonoBehaviour
{

    public GameObject scoreController;

    public ScoreController sc;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("ShowStar1", 3f);
        Invoke("ShowStar2", 5f);
        Invoke("ShowStar3", 7f);
        Invoke("ShowStar4", 9f);
        Invoke("ShowStar5", 11f);

        Invoke("PlayAudio1", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowStar1()
    {
        scoreController.SetActive(true);

        sc.SetUpModule1();
    }

    void ShowStar2()
    {
        sc.SetUpModule2();
    }

    void ShowStar3()
    {
        sc.SetUpModule3();
    }

    void ShowStar4()
    {
        sc.SetUpModule4();
    }

    void ShowStar5()
    {
        sc.SetUpModule5();
    }

    void PlayAudio1()
    {
        //Start Pandy talking animation
        StartPandyTalking();
        FindObjectOfType<AudioController>().Play("Conclusion");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("Conclusion");

        Invoke("StopPandyTalking", waitTime);
        Invoke("End", waitTime + 5f);
    }

    void End()
    {
        SceneManager.LoadScene("End");
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
