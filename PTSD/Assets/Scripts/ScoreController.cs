using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

    public GameObject star1, star2, star3, star4, star5;

    public RectTransform star1Start, star2Start, star3Start, star4Start, star5Start;

    public RectTransform star1End, star2End, star3End, star4End, star5End;

    public bool moveStar1, moveStar2, moveStar3, moveStar4, moveStar5;

    private Vector3 startScale = Vector3.zero;
    private Vector3 endScale = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = startScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, endScale, Time.deltaTime * 1);

        if (moveStar1 == true)
        {
            star1.transform.position = Vector3.Lerp(star1.transform.position, star1End.position, Time.deltaTime * 1);
        }

        if (moveStar2 == true)
        {
            star2.transform.position = Vector3.Lerp(star2.transform.position, star2End.position, Time.deltaTime * 1);
        }

        if (moveStar3 == true)
        {
            star3.transform.position = Vector3.Lerp(star3.transform.position, star3End.position, Time.deltaTime * 1);
        }

        if (moveStar4 == true)
        {
            star4.transform.position = Vector3.Lerp(star4.transform.position, star4End.position, Time.deltaTime * 1);
        }

        if (moveStar5 == true)
        {
            star5.transform.position = Vector3.Lerp(star5.transform.position, star5End.position, Time.deltaTime * 1);
        }
    }



    public void SetUpModule1()
    { 
        Invoke("MoveStar1", 3f);
    }

    public void SetUpModule2()
    {
        star1.SetActive(true);

        Invoke("MoveStar2", 3f);
    }

    public void SetUpModule3()
    {
        star1.SetActive(true);
        star2.SetActive(true);

        Invoke("MoveStar3", 3f);
    }

    public void SetUpModule4()
    {
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);

        Invoke("MoveStar4", 3f);
    }

    public void SetUpModule5()
    {
        star1.SetActive(true);
        star2.SetActive(true);
        star3.SetActive(true);
        star4.SetActive(true);

        Invoke("MoveStar5", 3f);
    }

    void MoveStar1()
    {
        star1.transform.position = star1Start.position;

        star1.SetActive(true);

        moveStar1 = true;

        FindObjectOfType<AudioController>().Play("Complete");
    }

    void MoveStar2()
    {
        star2.transform.position = star2Start.position;

        star2.SetActive(true);

        moveStar2 = true;

        FindObjectOfType<AudioController>().Play("Complete");
    }

    void MoveStar3()
    {
        star3.transform.position = star3Start.position;

        star3.SetActive(true);

        moveStar3 = true;

        FindObjectOfType<AudioController>().Play("Complete");
    }

    void MoveStar4()
    {
        star4.transform.position = star4Start.position;

        star4.SetActive(true);

        moveStar4 = true;

        FindObjectOfType<AudioController>().Play("Complete");
    }

    void MoveStar5()
    {
        star5.transform.position = star5Start.position;

        star5.SetActive(true);

        moveStar5 = true;

        FindObjectOfType<AudioController>().Play("Complete");
    }
}
