using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallervirus : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("VRhands"))
        {
            
            this.gameObject.SetActive(false);

        }
        if (other.gameObject.CompareTag("ButtonHand"))
        {

            this.gameObject.SetActive(false);

        }
        if (other.gameObject.CompareTag("Sanitizer"))
        {
            
            this.gameObject.SetActive(false);

        }
    }
}
