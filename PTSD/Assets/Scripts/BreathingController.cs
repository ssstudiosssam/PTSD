using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreathingController : MonoBehaviour
{
    private float waitBetweenSpeech;

    public Word word;

    public GameObject beachBall;

    public BeachBall bb;

    public GameObject scoreController;
    public ScoreController sc;

    public GameObject fireWorks;

    public GameObject continueButton;

    void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");

        beachBall.SetActive(false);
        fireWorks.SetActive(false);

        waitBetweenSpeech = 5f;

        Invoke("Intro", 15f);

        FindObjectOfType<AudioController>().Play("CalmPiano");
        FindObjectOfType<AudioController>().Play("OceanWaves");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Intro()
    {
        Debug.Log("INTRO");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE00");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE00");

        Invoke("StepOne", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepOne()
    {
        Debug.Log("STEP 1");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE01");

        word.DisplayText("RELAX", Color.red);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE01");

        Invoke("StepTwo", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwo()
    {
        Debug.Log("STEP 2");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE02");

        word.DisplayText("BREATHE DEEPLY", Color.yellow);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE02");

        Invoke("StepThree", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThree()
    {
        Debug.Log("STEP 3");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE03");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE03");

        Invoke("StepFour", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepFour()
    {
        Debug.Log("STEP 4");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE04");

        word.DisplayText("OXYGEN", Color.magenta);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE04");

        Invoke("StepFive", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepFive()
    {
        Debug.Log("STEP 5");

        //Start Pandy talking animation
        StartPandyTalking();

        beachBall.SetActive(true);

        FindObjectOfType<AudioController>().Play("BE05");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE05");

        Invoke("StepSix", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepSix()
    {
        Debug.Log("STEP 6");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE06");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE06");

        Invoke("StepSeven", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepSeven()
    {
        Debug.Log("STEP 7");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE07");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE07");

        Invoke("StepEight", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepEight()
    {
        Debug.Log("STEP 8");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE08");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE08");

        Invoke("StepNine", waitTime);
    }

    void StepNine()
    {
        Debug.Log("STEP 9");

        //Start Pandy talking animation
        StartPandyTalking();

        bb.MakeGrow();

        FindObjectOfType<AudioController>().Play("BE09");

        word.DisplayText("BREATHE IN", Color.green);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE09");

        Invoke("StepTen", 3f);
    }

    void StepTen()
    {
        Debug.Log("STEP 10");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE10");

        word.DisplayText("BREATHE OUT", Color.blue);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE10");

        Invoke("StepEleven", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepEleven()
    {
        Debug.Log("STEP 11");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE11");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE11");

        Invoke("StepTwelve", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwelve()
    {
        Debug.Log("STEP 12");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE12");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE12");

        Invoke("StepThirteen", waitTime + waitBetweenSpeech + 1f);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirteen()
    {
        Debug.Log("STEP 13");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE13");

        word.DisplayText("BREATHE IN", Color.red);

        Invoke("StepFourteen", 3f);
    }

    void StepFourteen()
    {
        Debug.Log("STEP 14");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE14");

        word.DisplayText("BREATHE OUT", Color.yellow);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE14");

        Invoke("StepFifteen", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepFifteen()
    {
        Debug.Log("STEP 15");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE15");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE15");

        Invoke("StepSixteen", waitTime + waitBetweenSpeech + 12f);
        //Time with no narration but ball growing and shrinkning
        Invoke("StopPandyTalking", waitTime);
    }

    void StepSixteen()
    {
        Debug.Log("STEP 16");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE16");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE16");

        Invoke("StepSeventeen", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepSeventeen()
    {
        Debug.Log("STEP 17");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE17");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE17");

        Invoke("StepEighteen", waitTime + waitBetweenSpeech + 5f);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepEighteen()
    {
        Debug.Log("STEP 18");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE18");

        word.DisplayText("BREATHE IN", Color.magenta);

        Invoke("StepNineteen", 3f);
    }

    void StepNineteen()
    {
        Debug.Log("STEP 19");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE19");

        word.DisplayText("BREATHE OUT", Color.green);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE19");

        Invoke("StepTwenty", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwenty()
    {
        Debug.Log("STEP 20");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE20");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE20");

        Invoke("StepTwentyone", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentyone()
    {
        Debug.Log("STEP 21");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE21");

        word.DisplayText("COMFORTABLE", Color.blue);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE21");

        Invoke("StepTwentytwo", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentytwo()
    {
        Debug.Log("STEP 22");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE22");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE22");

        Invoke("StepTwentythree", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentythree()
    {
        Debug.Log("STEP 23");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE23");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE23");

        Invoke("StepTwentyfour", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    public void StepTwentyfour()
    {
        Debug.Log("STEP 24");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE24");

        word.DisplayText("SAFE", Color.red);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE24");

        Invoke("StepTwentyfive", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentyfive()
    {
        Debug.Log("STEP 25");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE25");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE25");

        Invoke("StepTwentysix", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentysix()
    {
        Debug.Log("STEP 26");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE26");

        word.DisplayText("SAFE", Color.yellow);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE26");

        Invoke("StepTwentyseven", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentyseven()
    {
        Debug.Log("STEP 27");

        //Start Pandy talking animation
        StartPandyTalking();

        bb.StopGrow();

        FindObjectOfType<AudioController>().Play("BE27");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE27");

        Invoke("StepTwentyeight", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentyeight()
    {
        Debug.Log("STEP 28");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE28");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE28");

        Invoke("StepTwentynine", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepTwentynine()
    {
        Debug.Log("STEP 29");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE29");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE29");

        Invoke("StepThirty", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirty()
    {
        Debug.Log("STEP 30");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE30");

        word.DisplayText("RELAXED", Color.magenta);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE30");

        Invoke("StepThirtyone", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtyone()
    {
        Debug.Log("STEP 31");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE31");

        word.DisplayText("COMFORTABLE", Color.green);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE31");

        Invoke("StepThirtytwo", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtytwo()
    {
        Debug.Log("STEP 32");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE32");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE32");

        Invoke("StepThirtythree", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtythree()
    {
        Debug.Log("STEP 33");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE33");

        word.DisplayText("SAFE", Color.blue);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE33");

        Invoke("StepThirtyfour", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtyfour()
    {
        Debug.Log("STEP 34");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE34");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE34");

        Invoke("StepThirtyfive", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtyfive()
    {
        Debug.Log("STEP 35");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE35");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE35");

        Invoke("StepThirtysix", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtysix()
    {
        Debug.Log("STEP 36");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE36");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE36");

        Invoke("StepThirtyseven", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtyseven()
    {
        Debug.Log("STEP 37");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE37");

        word.DisplayText("CALM", Color.red);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE37");

        Invoke("StepThirtyeight", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtyeight()
    {
        Debug.Log("STEP 38");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE38");
        FindObjectOfType<AudioController>().Play("Complete");

        word.DisplayText("WELL DONE", Color.yellow);

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE38");

        scoreController.SetActive(true);
        sc.SetUpModule2();

        fireWorks.SetActive(true);

        Invoke("StepThirtynine", waitTime + waitBetweenSpeech);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepThirtynine()
    {
        Debug.Log("STEP 39");

        //Start Pandy talking animation
        StartPandyTalking();

        FindObjectOfType<AudioController>().Play("BE39");

        float waitTime = FindObjectOfType<AudioController>().ReturnClipLength("BE39");

        Invoke("StepForty", waitTime);
        Invoke("StopPandyTalking", waitTime);
    }

    void StepForty()
    {
        Debug.Log("STEP 40");

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
