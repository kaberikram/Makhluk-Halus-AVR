using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskPickup : MonoBehaviour
{

    int maskPick;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("vrPlayer") && (PlayerMaskHealth.Mask < 3))
        {

            maskPick = PlayerMaskHealth.Mask += 1;
            this.gameObject.SetActive(false);


        }
    }
}
