using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KlusterHealth : MonoBehaviour
{
    int KlusterHit;



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("vrPlayer"))
        {

            KlusterHit = PlayerMaskHealth.Mask -= 1;
            this.gameObject.SetActive(false);


        }
    }
}
