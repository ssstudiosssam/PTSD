using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCubeGrabber : OVRGrabbable
{

    public BrickController bc;

    protected override void Start()
    {
        base.Start();
    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        if (bc.brickPlaced == false)
        {
            base.GrabBegin(hand, grabPoint);
        }
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        base.GrabEnd(linearVelocity, angularVelocity);
        bc.PlaceBrick();
    }
}
