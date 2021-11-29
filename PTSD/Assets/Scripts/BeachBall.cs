using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachBall : MonoBehaviour
{

    private Vector3 TargetSize;
    private Vector3 SmallSize;
    private Vector3 BigSize;
    private Vector3 NoSize;

    public float growSpeed;

    public bool stillGrowing = true;

    // Start is called before the first frame update
    void Start()
    {
        SmallSize = new Vector3(2, 2, 2);
        BigSize = new Vector3(3, 3, 3);

        TargetSize = SmallSize;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, TargetSize, Time.deltaTime * growSpeed);

        if (Input.GetKeyDown(KeyCode.A))
        {
            MakeGrow();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            MakeShrink();
        }
    }

    public void MakeGrow()
    {
        TargetSize = BigSize;

        Debug.Log("BB GROW");

        Invoke("MakeShrink", 3f);
    }

    public void MakeShrink()
    {
        TargetSize = SmallSize;

        Debug.Log("BB SHRINK");

        if (stillGrowing == true)
        {
            Invoke("MakeGrow", 3f);
        }
    }

    public void StopGrow()
    {
        stillGrowing = false;
    }
}
