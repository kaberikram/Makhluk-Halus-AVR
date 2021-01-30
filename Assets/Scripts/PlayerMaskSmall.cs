using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskSmall : MonoBehaviour
{
    int MaskHit;


    // Start is called before the first frame update

   


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
     
        if (other.gameObject.CompareTag("VirusSmall"))
        {
            MaskHit = PlayerMaskHealth.Mask -= 1;
            Debug.Log("Mask lose 1");
        }



    }




}
