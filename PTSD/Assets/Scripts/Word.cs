using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Word : MonoBehaviour
{

    public TextMeshProUGUI word;

    private Vector3 startScale;
    private Vector3 endScale;

    private Vector3 startPosition;
    private Vector3 endPosition;

    private float speed;

    public Transform wordPosition;
    public Transform user;

    private Vector3 targetAngle = Vector3.zero;

    private Vector2 checkScale = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
        word.text = "";

        startScale = new Vector3(0, 0, 0);
        endScale = new Vector3(1, 1, 1);

        endPosition = new Vector3(0, 0, 0);

        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            DisplayText("yooooo", Color.cyan);
        }

        transform.localScale = Vector3.Lerp(transform.localScale, endScale, Time.deltaTime * speed);

        transform.position = Vector3.Lerp(transform.position, endPosition, Time.deltaTime * speed);

        transform.LookAt(user);

        //targetAngle = transform.localEulerAngles;
        //targetAngle.x = 0;
        //targetAngle.z = 0;
        //transform.localEulerAngles = targetAngle;

        if (transform.localScale.x > checkScale.x)
        {
            ChangeScale();
        }

    }

    public void DisplayText(string newWord, Color color)
    {


        StartCoroutine(IntroFade(word));

        if (wordPosition.position.y < 1)
        {
            Vector3 newPostion = new Vector3(wordPosition.position.x, 1f, wordPosition.position.z);
            wordPosition.position = newPostion;
        }

        transform.position = wordPosition.position;

        endPosition = new Vector3(wordPosition.position.x, wordPosition.position.y + 1f, wordPosition.position.z - 1f);

        transform.localScale = startScale;

        word.text = newWord;
        word.color = color;

        endScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    private void ChangeScale()
    {
        endScale = new Vector3(0, 0, 0);
    }

    private IEnumerator IntroFade(TextMeshProUGUI textToUse)
    {
        yield return StartCoroutine(FadeInText(1f, textToUse));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(FadeOutText(1f, textToUse));
        //End of transition, do some extra stuff!!
    }

    private IEnumerator FadeInText(float timeSpeed, TextMeshProUGUI text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime * timeSpeed));
            yield return null;
        }
    }
    private IEnumerator FadeOutText(float timeSpeed, TextMeshProUGUI text)
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
        while (text.color.a > 0.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a - (Time.deltaTime * timeSpeed));
            yield return null;
        }
    }
}
