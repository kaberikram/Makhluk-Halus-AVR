using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public AudioSource warningSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WarningTrigger")
        {
            warningSound.Play();
        }
    }
}
