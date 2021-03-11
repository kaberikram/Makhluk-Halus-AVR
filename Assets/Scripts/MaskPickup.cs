using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskPickup : MonoBehaviour
{
    

    int maskPick;
    public GameObject DummyMask;
    public AudioClip HealClip;
    public AudioSource HealSource;
    // Start is called before the first frame update
    void Start()
    {

        DummyMask.gameObject.SetActive(false);
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ring") && (PlayerMaskHealth.Mask < 4))
        {
            //this.gameObject.SetActive(false);
            maskPick = PlayerMaskHealth.Mask += 1;
            HealSource.PlayOneShot(HealClip);
            //GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.SetActive(false);
            DummyMask.gameObject.SetActive(true);
            Invoke("HideMask", 0.5f);

        }

      
    }

    public void HideMask()
    {
        DummyMask.gameObject.SetActive(false);
    }
    /*private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            DummyMask.gameObject.SetActive(false);

        }

    }*/


}
