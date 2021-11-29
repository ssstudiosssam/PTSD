using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeMatchController : MonoBehaviour
{

    public GameObject cube1, cube2, cube3, cube4;

    public GameObject positiveCube1, positiveCube2, positiveCube3, positiveCube4;

    private int nCube1Pos, nCube2Pos, nCube3Pos, nCube4Pos;

    public int pCube1Pos, pCube2Pos, pCube3Pos, pCube4Pos;

    public Transform[] cubePosition;

    public int numOfCubesPlaced;

    public GameObject checkResults;

    public TextMeshProUGUI nC1, nC2, nC3, nC4, pC1, pC2, pC3, pC4, resultText;

    public Material positiveMaterial, negativeMaterial;

    public bool correct;

    public Color positiveEndColour, positiveStartColour, negativeEndColour, negativeStartColour;

    public GameObject scoreController;
    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject continueButton;

    public GameObject continueButtonWrong;
    public GameObject wrongCanvas;

    // Start is called before the first frame update
    void Start()
    {
        //Start
        GenerateCube1Pos();

        positiveMaterial.color = positiveStartColour;
        negativeMaterial.color = negativeStartColour;

        Invoke("PlayAudio1", 3f);
    }

    void PlayAudio1()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("1Game01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("1Game01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + 3f);
    }

    void PlayAudio2()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("1Game02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("1Game02");

        Invoke("StopPandyTalking", waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(correct == true)
        {
            positiveMaterial.color = Color.Lerp(positiveMaterial.color, positiveEndColour, 1f * Time.deltaTime);
            negativeMaterial.color = Color.Lerp(negativeMaterial.color, negativeEndColour, 1f * Time.deltaTime);
        }
    }

    void GenerateCube1Pos()
    {
        nCube1Pos = Random.Range(1, 5);
        Debug.Log("SAD" + nCube1Pos);
        GenerateCube2Pos();
    }

    void GenerateCube2Pos()
    {
        nCube2Pos = Random.Range(1, 5);

        if (nCube2Pos == nCube1Pos)
        {
            GenerateCube2Pos();
        }
        else
        {
            Debug.Log("ANGRY" + nCube2Pos);
            GenerateCube3Pos();
        }
    }

    void GenerateCube3Pos()
    {
        nCube3Pos = Random.Range(1, 5);

        if (nCube3Pos == nCube1Pos || nCube3Pos == nCube2Pos)
        {
            GenerateCube3Pos();
        }
        else
        {
            Debug.Log("SCARED" + nCube3Pos);
            GenerateCube4Pos();
        }
    }

    void GenerateCube4Pos()
    {
        nCube4Pos = Random.Range(1, 5);

        if (nCube4Pos == nCube1Pos || nCube4Pos == nCube2Pos || nCube4Pos == nCube3Pos)
        {
            GenerateCube4Pos();
        }
        else
        {
            Debug.Log("FRUSTRATED" + nCube4Pos);
            PlaceCubes();
        }

        UpdateText();
    }

    void PlaceCubes()
    {
        cube1.transform.position = cubePosition[nCube1Pos - 1].position;
        cube2.transform.position = cubePosition[nCube2Pos - 1].position;
        cube3.transform.position = cubePosition[nCube3Pos - 1].position;
        cube4.transform.position = cubePosition[nCube4Pos - 1].position;

        /*
        Instantiate(cube1, cubePosition[nCube1Pos - 1].position, Quaternion.identity);
        Instantiate(cube2, cubePosition[nCube2Pos - 1].position, Quaternion.identity);
        Instantiate(cube3, cubePosition[nCube3Pos - 1].position, Quaternion.identity);
        Instantiate(cube4, cubePosition[nCube4Pos - 1].position, Quaternion.identity);
        */

        PlaceNextPositiveCube();
    }

    public void PlaceNextPositiveCube()
    {
        if (numOfCubesPlaced == 0)
        {
            positiveCube1.SetActive(true);
        }

        if (numOfCubesPlaced == 1)
        {
            positiveCube2.SetActive(true);
        }

        if (numOfCubesPlaced == 2)
        {
            positiveCube3.SetActive(true);
        }

        if (numOfCubesPlaced == 3)
        {
            positiveCube4.SetActive(true);
        }

        if (numOfCubesPlaced == 4)
        {
            checkResults.SetActive(true);
        }
    }

    public void UpdateText()
    {
        nC1.text = nCube1Pos.ToString();
        nC2.text = nCube2Pos.ToString();
        nC3.text = nCube3Pos.ToString();
        nC4.text = nCube4Pos.ToString();

        pC1.text = pCube1Pos.ToString();
        pC2.text = pCube2Pos.ToString();
        pC3.text = pCube3Pos.ToString();
        pC4.text = pCube4Pos.ToString();
    }

    public void CheckScores()
    {
        if (nCube1Pos == pCube1Pos && nCube2Pos == pCube2Pos && nCube3Pos == pCube3Pos && nCube4Pos == pCube4Pos)
        {
            resultText.text = "CORRECT";
            Correct();
        }
        else
        {
            resultText.text = "WRONG";
            Wrong();
        }

        checkResults.SetActive(false);
    }

    private void Correct()
    {
        correct = true;

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("1Game03");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("1Game03");

        Invoke("StopPandyTalking", waitTime);

        Invoke("ShowResults", waitTime + 3f);
    }

    private void Wrong()
    {
        wrongCanvas.SetActive(true);
        FindObjectOfType<AudioController>().Play("Wrong");
        Invoke("StartAgain", 3f);
    }

    private void ShowResults()
    {
        scoreController.SetActive(true);
        sc.SetUpModule4();
        fireWorks.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("1Game04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("1Game04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("ShowContinueButton", waitTime + 3f);
    }

    private void ShowContinueButton()
    {
        continueButton.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("1Game05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("1Game05");

        Invoke("StopPandyTalking", waitTime);
    }

    private void StartAgain()
    {
        continueButtonWrong.SetActive(true);
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
