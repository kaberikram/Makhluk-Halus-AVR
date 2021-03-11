using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public AudioSource warningSound;
    public AudioClip ClusterClip;
    //private float buttonHitAgainTime = 0.5f;
    //private float canHitAgain;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WarningTrigger")
        {
            warningSound.PlayOneShot(ClusterClip);
        }
    }
}
