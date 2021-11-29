using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenController : MonoBehaviour
{

    public Transform tip;

    public GameObject Red, Yellow, Green, Cyan, Blue, Pink, White, Black;

    public bool DrawRed, DrawYellow, DrawGreen, DrawCyan, DrawBlue, DrawPink, DrawWhite, DrawBlack;

    public Material pencil1Material, pencil2Material;

    public bool pencil1, pencil2;

    // Start is called before the first frame update
    void Start()
    {
        SetColourBlack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider target)
    {
        if (target.tag == "Paper")
        {
            if (DrawRed == true)
            {
                Debug.Log("Draw red");
                Instantiate(Red, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawYellow == true)
            {
                Debug.Log("Draw yellow");
                Instantiate(Yellow, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawGreen == true)
            {
                Debug.Log("Draw green");
                Instantiate(Green, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawCyan == true)
            {
                Debug.Log("Draw cyan");
                Instantiate(Cyan, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawBlue == true)
            {
                Debug.Log("Draw blue");
                Instantiate(Blue, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawPink == true)
            {
                Debug.Log("Draw pink");
                Instantiate(Pink, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawWhite == true)
            {
                Debug.Log("Draw white");
                Instantiate(White, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }

            if (DrawBlack == true)
            {
                Debug.Log("Draw black");
                Instantiate(Black, new Vector3(tip.position.x, tip.transform.position.y, 1.949f), Quaternion.identity);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Red")
        {
            SetColourRed();
        }

        if (other.tag == "Yellow")
        {
            SetColourYellow();
        }

        if (other.tag == "Green")
        {
            SetColourGreen();
        }

        if (other.tag == "Cyan")
        {
            SetColourCyan();
        }

        if (other.tag == "Blue")
        {
            SetColourBlue();
        }

        if (other.tag == "Pink")
        {
            SetColourPink();
        }

        if (other.tag == "White")
        {
            SetColourWhite();
        }

        if (other.tag == "Black")
        {
            SetColourBlack();
        }
    }

    void SetColourRed()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.red);
            AllColoursFalse();
            DrawRed = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.red);
            AllColoursFalse();
            DrawRed = true;
        }
    }

    void SetColourYellow()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.yellow);
            AllColoursFalse();
            DrawYellow = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.yellow);
            AllColoursFalse();
            DrawYellow = true;
        }
    }

    void SetColourGreen()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.green);
            AllColoursFalse();
            DrawGreen = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.green);
            AllColoursFalse();
            DrawGreen = true;
        }
    }

    void SetColourCyan()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.cyan);
            AllColoursFalse();
            DrawCyan = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.cyan);
            AllColoursFalse();
            DrawCyan = true;
        }
    }

    void SetColourBlue()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.blue);
            AllColoursFalse();
            DrawBlue = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.blue);
            AllColoursFalse();
            DrawBlue = true;
        }
    }

    void SetColourPink()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.magenta);
            AllColoursFalse();
            DrawPink = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.magenta);
            AllColoursFalse();
            DrawPink = true;
        }
    }

    void SetColourWhite()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.white);
            AllColoursFalse();
            DrawWhite = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.white);
            AllColoursFalse();
            DrawWhite = true;
        }
    }

    void SetColourBlack()
    {
        if (pencil1 == true)
        {
            pencil1Material.SetColor("_Color", Color.black);
            AllColoursFalse();
            DrawBlack = true;
        }

        if (pencil2 == true)
        {
            pencil2Material.SetColor("_Color", Color.black);
            AllColoursFalse();
            DrawBlack = true;
        }
    }

    void AllColoursFalse()
    {
        DrawRed = false;
        DrawYellow = false;
        DrawGreen = false;
        DrawCyan = false;
        DrawBlue = false;
        DrawPink = false;
        DrawWhite = false;
        DrawBlack = false;
    }
}
