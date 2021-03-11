using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button3 : MonoBehaviour
{
    public GameObject blackOutSquare;
    public AudioSource VhitSource;
    public AudioClip VhitClip;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("VRhands"))
        {
            Invoke("Change2", 2.0f);
            VhitSource.PlayOneShot(VhitClip);
            StartCoroutine(FadeBlackOutSquare());

        }


    }
    public void Change2()
    {
        SceneManager.LoadScene("LEVEL_01");
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
