using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorScript : MonoBehaviour
{

    public GameObject warning;
    public AudioSource warningSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "vrPlayer")
        {
            warning.SetActive(true);
            StartCoroutine("WaitForSec");
            warningSound.Play();
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        warning.SetActive(false);
    }
}
