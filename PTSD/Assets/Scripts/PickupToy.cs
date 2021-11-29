using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupToy : MonoBehaviour
{

    public GameObject otherToy1, otherToy2;

    public GameObject leftHand, rightHand;

    private bool toySelected = false;

    public BreathingController bc;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand" && toySelected == false)
        {
            Debug.Log("PICK UP LEFT HAND");

            transform.position = leftHand.transform.position;
            transform.rotation = leftHand.transform.rotation;

            transform.parent = leftHand.transform;

            if (toySelected == false)
            {
                otherToy1.SetActive(false);
                otherToy2.SetActive(false);

                bc.StepTwentyfour();
                toySelected = true;
            }
        }

        if (other.gameObject.tag == "RightHand" && toySelected == false)
        {
            Debug.Log("PICK UP RIGHT HAND");

            transform.position = rightHand.transform.position;
            transform.rotation = leftHand.transform.rotation;

            transform.parent = rightHand.transform;

            if (toySelected == false)
            {
                otherToy1.SetActive(false);
                otherToy2.SetActive(false);

                bc.StepTwentyfour();
                toySelected = true;
            }
        }
    }
}
