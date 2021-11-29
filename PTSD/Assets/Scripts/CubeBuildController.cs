using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBuildController : MonoBehaviour
{

    public GameObject ExplodeCube1, ExplodeCube2, ExplodeCube3, ExplodeCube4, ExplodeCube5, ExplodeCube6, ExplodeCube7, ExplodeCube8, ExplodeCube9;

    private bool wallExploded = false;

    public bool brick1PositionFull, brick2PositionFull, brick3PositionFull, brick4PositionFull, brick5PositionFull, brick6PositionFull, brick7PositionFull, brick8PositionFull, brick9PositionFull;

    public GameObject scoreController;
    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject continueButton;

    private bool endSent;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayAudio1", 3f);
    }

    void PlayAudio1()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("4Game01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("4Game01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + 3f);
    }

    void PlayAudio2()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("4Game02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("4Game02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio3", waitTime + 3f);
    }

    void PlayAudio3()
    {
        //Explode house
        SendExplosion();
        FindObjectOfType<AudioController>().Play("Negative");

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("4Game03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("4Game03");

        Invoke("StopPandyTalking", waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (wallExploded == false)
            {
                SendExplosion();
                wallExploded = true;
            }
        }

        if (brick1PositionFull == true && brick2PositionFull == true && brick3PositionFull == true && brick4PositionFull == true && brick5PositionFull == true && brick6PositionFull == true && brick7PositionFull == true && brick8PositionFull == true && brick9PositionFull == true)
        {
            if (endSent == false)
            {
                ShowResults();
                endSent = true;
            }
        }
    }

    private void SendExplosion()
    {
        ExplodeCube1.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube2.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube3.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube4.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube5.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube6.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube7.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube8.GetComponent<WallCubeExploder>().ExplodeWall();
        ExplodeCube9.GetComponent<WallCubeExploder>().ExplodeWall();
    }

    private void ShowResults()
    {
        scoreController.SetActive(true);
        sc.SetUpModule4();
        fireWorks.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("4Game04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("4Game04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("NextInstruction", waitTime + 3f);

    }

    private void NextInstruction()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("4Game05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("4Game05");

        Invoke("StopPandyTalking", waitTime);
        Invoke("ShowContinueButton", waitTime + 3f);
    }

    private void ShowContinueButton()
    {
        continueButton.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("4Game06");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("4Game06");

        Invoke("StopPandyTalking", waitTime);
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
