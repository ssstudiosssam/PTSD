using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveCubeGrabber : OVRGrabbable
{

    public PositiveCubeController pcc;

    protected override void Start()
    {
        base.Start();
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        pcc.PlaceCube();
    }
}
