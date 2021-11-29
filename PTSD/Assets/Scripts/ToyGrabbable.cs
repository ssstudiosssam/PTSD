using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyGrabbable : OVRGrabbable
{

    private bool toyGrabbed = false;

    public BreathingController bc;

    public GameObject toy1, toy2;

    protected override void Start()
    {
        base.Start();
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        base.GrabBegin(hand, grabPoint);

        if (toyGrabbed == false)
        {
            //s1b.StepFive();

            toy1.SetActive(false);
            toy2.SetActive(false);

            toyGrabbed = true;
        }
    }
}
