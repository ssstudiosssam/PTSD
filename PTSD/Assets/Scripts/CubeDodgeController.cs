using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeDodgeController : MonoBehaviour
{

    private int score;
    public TextMeshProUGUI scoreText;
    public Image hitImage;

    public Image star1, star2;

    public Color positiveColour, negativeColour, normalColour;

    private bool moveToNormal, moveToNegative, moveToPositive;

    public Light l1, l2;

    private float dimValue = 0.5f, brightValue = 1.5f, normalValue = 1f;

    private float completeValue;

    public CubeSpawner cs;

    public GameObject cubeSpawner;

    public bool playing = true;

    public GameObject scoreController;
    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject continueButton;

    private bool endGameSent;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();

        Invoke("PlayAudio1", 3f);
    }

    void PlayAudio1()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("5Game01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("5Game01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + 3f);
    }

    void PlayAudio2()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("5Game02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("5Game02");

        Invoke("StopPandyTalking", waitTime);
        Invoke("StartGame", waitTime + 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveToPositive == true)
        {
            hitImage.color = Color.Lerp(hitImage.color, positiveColour, 1f * Time.deltaTime);
            l1.intensity = Mathf.Lerp(l1.intensity, brightValue, 1f * Time.deltaTime);
            l2.intensity = Mathf.Lerp(l1.intensity, brightValue, 1f * Time.deltaTime);
        }

        if (moveToNegative == true)
        {
            hitImage.color = Color.Lerp(hitImage.color, negativeColour, 1f * Time.deltaTime);
            l1.intensity = Mathf.Lerp(l1.intensity, dimValue, 1f * Time.deltaTime);
            l2.intensity = Mathf.Lerp(l1.intensity, dimValue, 1f * Time.deltaTime);
        }

        if (moveToNormal == true)
        {
            hitImage.color = Color.Lerp(hitImage.color, Color.clear, 5f * Time.deltaTime);
            l1.intensity = Mathf.Lerp(l1.intensity, normalValue, 1f * Time.deltaTime);
            l2.intensity = Mathf.Lerp(l1.intensity, normalValue, 1f * Time.deltaTime);
        }

        completeValue = score / 10f;

        star1.fillAmount = Mathf.Lerp(star1.fillAmount, completeValue, 1f * Time.deltaTime);
        star2.fillAmount = Mathf.Lerp(star1.fillAmount, completeValue, 1f * Time.deltaTime);

        if (score >= 10 && endGameSent == false)
        {
            endGameSent = true;
            EndGame();
        }
    }

    public void AddScore()
    {
        score = score + 1;

        SetNormalColour();

        moveToPositive = true;
        Invoke("SetNormalColour", .5f);

        UpdateText();
    }

    public void SubtractScore()
    {
        score = score - 1;

        SetNormalColour();

        moveToNegative = true;
        Invoke("SetNormalColour", .5f);

        UpdateText();
    }

    private void UpdateText()
    {
        scoreText.text = score.ToString();
    }

    private void SetNormalColour()
    {
        moveToNegative = false;
        moveToPositive = false;
        moveToNormal = true;
    }

    private void HideImage()
    {
        hitImage.color = normalColour;
    }

    public void StartGame()
    {
        cubeSpawner.SetActive(true);
    }

    private void EndGame()
    {
        playing = false;
        cs.StopCubes();
        cubeSpawner.SetActive(false);
        scoreController.SetActive(true);
        sc.SetUpModule4();
        fireWorks.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("5Game03");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("5Game03");

        Invoke("StopPandyTalking", waitTime);
        Invoke("NextInstruction", waitTime + 3f);
    }

    private void NextInstruction()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("5Game04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("5Game04");

        Invoke("StopPandyTalking", waitTime);
        Invoke("ShowContinueButton", waitTime + 3f);
    }

    private void ShowContinueButton()
    {
        continueButton.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("5Game05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("5Game05");

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
