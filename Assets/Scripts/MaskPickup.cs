using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskPickup : MonoBehaviour
{
    

    int maskPick;
    public GameObject DummyMask;
    // Start is called before the first frame update
    void Start()
    {

        DummyMask.gameObject.SetActive(false);
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ring") && (PlayerMaskHealth.Mask < 3))
        {
            //this.gameObject.SetActive(false);
            maskPick = PlayerMaskHealth.Mask += 1;
            GetComponent<MeshRenderer>().enabled = false;
            DummyMask.gameObject.SetActive(true);

        }

      
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            DummyMask.gameObject.SetActive(false);

        }

    }


}
