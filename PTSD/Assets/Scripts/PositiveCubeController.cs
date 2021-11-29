using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveCubeController : MonoBehaviour
{

    private bool touchingBox;

    private int inBox;

    public Transform box1, box2, box3, box4;

    private bool newCubePlaced;

    public CubeMatchController cmc;

    public int box;

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
        if (other.tag == "Cube1" && touchingBox == false)
        {
            touchingBox = true;

            inBox = 1;

            Debug.Log("touching box 1");
        }

        if (other.tag == "Cube2" && touchingBox == false)
        {
            touchingBox = true;

            inBox = 2;

            Debug.Log("touching box 2");
        }

        if (other.tag == "Cube3" && touchingBox == false)
        {
            touchingBox = true;

            inBox = 3;

            Debug.Log("touching box 3");
        }

        if (other.tag == "Cube4" && touchingBox == false)
        {
            touchingBox = true;

            inBox = 4;

            Debug.Log("touching box 4");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cube1")
        {
            touchingBox = false;

            inBox = 0;

            Debug.Log("leaving box 1");
        }

        if (other.tag == "Cube2")
        {
            touchingBox = false;

            inBox = 0;

            Debug.Log("leaving box 2");
        }

        if (other.tag == "Cube3")
        {
            touchingBox = false;

            inBox = 0;

            Debug.Log("leaving box 3");
        }

        if (other.tag == "Cube4")
        {
            touchingBox = false;

            inBox = 0;

            Debug.Log("leaving box 4");
        }
    }

    public void PlaceCube()
    {
        if (inBox == 1)
        {
            transform.position = box1.position;
            transform.rotation = box1.rotation;

            if (newCubePlaced == false)
            {
                newCubePlaced = true;
                cmc.numOfCubesPlaced = cmc.numOfCubesPlaced + 1;
                cmc.PlaceNextPositiveCube();
            }

            UpdateBoxPosition();
        }

        if (inBox == 2)
        {
            transform.position = box2.position;
            transform.rotation = box2.rotation;

            if (newCubePlaced == false)
            {
                newCubePlaced = true;
                cmc.numOfCubesPlaced = cmc.numOfCubesPlaced + 1;
                cmc.PlaceNextPositiveCube();
            }

            UpdateBoxPosition();
        }

        if (inBox == 3)
        {
            transform.position = box3.position;
            transform.rotation = box3.rotation;

            if (newCubePlaced == false)
            {
                newCubePlaced = true;
                cmc.numOfCubesPlaced = cmc.numOfCubesPlaced + 1;
                cmc.PlaceNextPositiveCube();
            }

            UpdateBoxPosition();
        }

        if (inBox == 4)
        {
            transform.position = box4.position;
            transform.rotation = box4.rotation;

            if (newCubePlaced == false)
            {
                newCubePlaced = true;
                cmc.numOfCubesPlaced = cmc.numOfCubesPlaced + 1;
                cmc.PlaceNextPositiveCube();
            }
        }

        UpdateBoxPosition();
    }

    private void UpdateBoxPosition()
    {
        if (box == 1)
        {
            cmc.pCube1Pos = inBox;
            cmc.UpdateText();
        }

        if (box == 2)
        {
            cmc.pCube2Pos = inBox;
            cmc.UpdateText();
        }

        if (box == 3)
        {
            cmc.pCube3Pos = inBox;
            cmc.UpdateText();
        }

        if (box == 4)
        {
            cmc.pCube4Pos = inBox;
            cmc.UpdateText();
        }
    }
}
