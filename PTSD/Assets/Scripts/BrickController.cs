using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{

    private bool touchingBrick;

    private int brickPlace;

    public Transform brick1, brick2, brick3, brick4, brick5, brick6, brick7, brick8, brick9;

    public bool brickPlaced;

    public CubeBuildController cbc;

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
        if (other.tag == "Brick1" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 1;

            Debug.Log("in brick place 1");
        }

        if (other.tag == "Brick2" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 2;

            Debug.Log("in brick place 2");
        }

        if (other.tag == "Brick3" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 3;

            Debug.Log("in brick place 3");
        }

        if (other.tag == "Brick4" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 4;

            Debug.Log("in brick place 4");
        }

        if (other.tag == "Brick5" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 5;

            Debug.Log("in brick place 5");
        }

        if (other.tag == "Brick6" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 6;

            Debug.Log("in brick place 6");
        }

        if (other.tag == "Brick7" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 7;

            Debug.Log("in brick place 7");
        }

        if (other.tag == "Brick8" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 8;

            Debug.Log("in brick place 8");
        }

        if (other.tag == "Brick9" && touchingBrick == false)
        {
            touchingBrick = true;

            brickPlace = 9;

            Debug.Log("in brick place 9");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Brick1")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 1");
        }

        if (other.tag == "Brick2")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 2");
        }

        if (other.tag == "Brick3")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 3");
        }

        if (other.tag == "Brick4")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 4");
        }

        if (other.tag == "Brick5")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 5");
        }

        if (other.tag == "Brick6")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 6");
        }

        if (other.tag == "Brick7")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 7");
        }

        if (other.tag == "Brick8")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 8");
        }

        if (other.tag == "Brick9")
        {
            touchingBrick = false;

            brickPlace = 0;

            Debug.Log("leaving brick place 9");
        }
    }

    public void PlaceBrick()
    {
        if (brickPlace == 1)
        {
            if (cbc.brick1PositionFull == false)
            {
                transform.position = brick1.position;
                transform.rotation = brick1.rotation;

                brickPlaced = true;
                cbc.brick1PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 2)
        {
            if (cbc.brick2PositionFull == false)
            {
                transform.position = brick2.position;
                transform.rotation = brick2.rotation;

                brickPlaced = true;
                cbc.brick2PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 3)
        {
            if (cbc.brick3PositionFull == false)
            {
                transform.position = brick3.position;
                transform.rotation = brick3.rotation;

                brickPlaced = true;
                cbc.brick3PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 4)
        {
            if (cbc.brick4PositionFull == false)
            {
                transform.position = brick4.position;
                transform.rotation = brick4.rotation;

                brickPlaced = true;
                cbc.brick4PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 5)
        {
            if (cbc.brick5PositionFull == false)
            {
                transform.position = brick5.position;
                transform.rotation = brick5.rotation;

                brickPlaced = true;
                cbc.brick5PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 6)
        {
            if (cbc.brick6PositionFull == false)
            {
                transform.position = brick6.position;
                transform.rotation = brick6.rotation;

                brickPlaced = true;
                cbc.brick6PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 7)
        {
            if (cbc.brick7PositionFull == false)
            {
                transform.position = brick7.position;
                transform.rotation = brick7.rotation;

                brickPlaced = true;
                cbc.brick7PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 8)
        {
            if (cbc.brick8PositionFull == false)
            {
                transform.position = brick8.position;
                transform.rotation = brick8.rotation;

                brickPlaced = true;
                cbc.brick8PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }

        if (brickPlace == 9)
        {
            if (cbc.brick9PositionFull == false)
            {
                transform.position = brick9.position;
                transform.rotation = brick9.rotation;

                brickPlaced = true;
                cbc.brick9PositionFull = true;
                //positive sound
                FindObjectOfType<AudioController>().Play("Positive");
            }
            else
            {
                //negative sound
                FindObjectOfType<AudioController>().Play("Negative");
            }
        }
    }
}
