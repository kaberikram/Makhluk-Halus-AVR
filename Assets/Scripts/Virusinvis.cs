using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virusinvis : MonoBehaviour
{


    int virusHit;
    


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("vrPlayer"))
        {

            virusHit = VirusSpawner.currentAmmo += 1;
            this.gameObject.SetActive(false);


        }
    }


   

}