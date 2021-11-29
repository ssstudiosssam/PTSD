using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToyFinderController : MonoBehaviour
{

    private int toysLeft, toysFound;

    public TextMeshProUGUI toysLeftText, toysFoundText;

    public Light mainLight, spotLight;

    public bool toyJustFound;

    private float toyFoundLightValue;

    private float newDarkValue;

    public GameObject scoreController;
    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject continueButton;

    public GameObject Torch, leftHand, rightHand;

    // Start is called before the first frame update
    void Start()
    {
        toysLeft = 10;
        toysFound = 0;

        mainLight.intensity = 0.65f;
        spotLight.intensity = 0.65f;

        toyFoundLightValue = .8f;

        newDarkValue = 0.65f;

        UpdateText();

        Invoke("PlayAudio1", 3f);
    }

    void PlayAudio1()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("2Game01");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("2Game01");

        Invoke("StopPandyTalking", waitTime);
        Invoke("PlayAudio2", waitTime + 3f);
    }

    void PlayAudio2()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("2Game02");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("2Game02");

        Invoke("StopPandyTalking", waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (toyJustFound == true)
        {
            mainLight.intensity = Mathf.Lerp(mainLight.intensity, toyFoundLightValue, 1 * Time.deltaTime);
            spotLight.intensity = Mathf.Lerp(spotLight.intensity, toyFoundLightValue, 1 * Time.deltaTime);
        }

        if (toyJustFound == false)
        {
            mainLight.intensity = Mathf.Lerp(mainLight.intensity, newDarkValue, 1 * Time.deltaTime);
            spotLight.intensity = Mathf.Lerp(spotLight.intensity, newDarkValue, 1 * Time.deltaTime);
        }
    }

    private void UpdateText()
    {
        toysLeftText.text = toysLeft.ToString();
        toysFoundText.text = toysFound.ToString();
    }

    public void ToyFound()
    {
        toysLeft = toysLeft - 1;
        toysFound = toysFound + 1;

        FindObjectOfType<AudioController>().Play("ToyFound");

        toyJustFound = true;

        UpdateText();

        Invoke("FadeBack", 2);

        if (toysFound == 10)
        {
            EndGame();
        }
    }

    private void FadeBack()
    {
        toyJustFound = false;

        if (toysFound == 1)
        {
            newDarkValue = .6f;
        }

        if (toysFound == 2)
        {
            newDarkValue = .55f;
        }

        if (toysFound == 3)
        {
            newDarkValue = .5f;
        }

        if (toysFound == 4)
        {
            newDarkValue = .45f;
        }

        if (toysFound == 5)
        {
            newDarkValue = .4f;
        }

        if (toysFound == 6)
        {
            newDarkValue = .35f;
        }

        if (toysFound == 7)
        {
            newDarkValue = .3f;
        }

        if (toysFound == 8)
        {
            newDarkValue = .25f;
        }

        if (toysFound == 9)
        {
            newDarkValue = .2f;
        }

        if (toysFound == 10)
        {
            newDarkValue = 1f;
        }
    }

    private void EndGame()
    {
        scoreController.SetActive(true);
        sc.SetUpModule4();
        fireWorks.SetActive(true);

        Torch.SetActive(false);

        leftHand.SetActive(true);
        rightHand.SetActive(true);

        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("2Game04");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("2Game04");

        Invoke("StopPandyTalking", waitTime);

        Invoke("ShowContinueButton", waitTime + 3f);
    }

    private void ShowContinueButton()
    {
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("2Game05");
        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("2Game05");

        Invoke("StopPandyTalking", waitTime);

        continueButton.SetActive(true);
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
