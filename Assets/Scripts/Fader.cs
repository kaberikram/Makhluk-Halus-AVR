using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    public GameObject blackOutSquare;
    void Start()
    {

        StartCoroutine(FadeBlackOutSquare(false));

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(FadeBlackOutSquare());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(FadeBlackOutSquare(false));
        }
    }

    public void hitam()
    {
        StartCoroutine(FadeBlackOutSquare());
    }

    public IEnumerator FadeBlackOutSquare(bool fadeToblack = true, int fadeSpeed = 2)
    {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;

        if (fadeToblack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
        else
        {
            while (blackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

        }

    }
}
