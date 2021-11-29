using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafePenPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 1.949f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 1.949f);
        }
    }
}
