using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ContinueButtonController : MonoBehaviour
{

    private float continueValue;

    public float increaseSpeed;

    public Image progressImage;

    public string nextStage;

    public bool triggerEvent;

    public UnityEvent onContinue;

    // Start is called before the first frame update
    void Start()
    {
        continueValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider target)
    {
        if (target.tag == "Hand")
        {
            if (continueValue >= 1)
            {
                if (triggerEvent == false)
                {
                    NextScene();
                }
                else
                {
                    TriggerEvent();
                }            
            }
            else
            {
                continueValue = continueValue + (increaseSpeed * Time.deltaTime);
                ProgressFiller();
            }
        }
    }

    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Hand")
        {
            continueValue = 0f;
            ProgressFiller();
        }
    }

    private void ProgressFiller()
    {
        progressImage.fillAmount = continueValue;
    }

    private void NextScene()
    {
        SceneManager.LoadScene(nextStage);
    }

    private void TriggerEvent()
    {
        if (triggerEvent == true)
        {
            onContinue.Invoke();
        }
    }

}
