using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCubeExploder : MonoBehaviour
{

    Rigidbody rb;
    BoxCollider bc;
    public float power;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
    }

    public void ExplodeWall()
    {
        rb.AddForce(transform.right * -power);
        rb.AddForce(transform.forward * -power);
        rb.AddTorque(transform.forward * power);

        Invoke("RemoveGravity", 2f);
    }

    public void RemoveGravity()
    {
        rb.useGravity = false;
        bc.isTrigger = true;
    }
}
