using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDodgeChecker : MonoBehaviour
{

    public CubeDodgeController cdc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PositiveCube" && cdc.playing == true)
        {
            Destroy(other.gameObject);
            cdc.AddScore();
            FindObjectOfType<AudioController>().Play("PositiveCube");
            Debug.Log("Hit positive cube");
        }

        if (other.tag == "NegativeCube" && cdc.playing == true)
        {
            Destroy(other.gameObject);
            cdc.SubtractScore();
            FindObjectOfType<AudioController>().Play("NegativeCube");
            Debug.Log("Hit negative cube");
        }
    }
}
