using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeFound : MonoBehaviour
{

    private float foundValue;

    private float increaseSpeed = .5f;

    public Image progressImage;

    private bool toyFound;

    public ToyFinderController TFC;

    // Start is called before the first frame update
    void Start()
    {
        foundValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Light")
        {
            if (foundValue >= 1)
            {
                if (toyFound == false)
                {
                    toyFound = true;
                    TFC.ToyFound();
                }
            }
            else
            {
                Debug.Log("BEING FOUND");

                foundValue = foundValue + (increaseSpeed * Time.deltaTime);

                ProgressFiller();
            }
        }
    }

    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Light")
        {
            if (toyFound == false)
            {
                foundValue = 0f;
                ProgressFiller();
            }
        }
    }

    private void ProgressFiller()
    {
        progressImage.fillAmount = foundValue;
    }
}
