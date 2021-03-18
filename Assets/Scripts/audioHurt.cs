using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioHurt : MonoBehaviour
{
    public AudioSource VhitSource;
    public AudioClip VhitClip;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.CompareTag("VRhands"))
        {
            
            VhitSource.PlayOneShot(VhitClip);
           
           
        }
    }
}
