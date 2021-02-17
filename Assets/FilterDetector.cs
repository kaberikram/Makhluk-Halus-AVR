using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterDetector : MonoBehaviour
{
    public GameObject Dropzone;

    private void Start()
    {
        Dropzone.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Filter"))
        {
            Dropzone.gameObject.SetActive(true);
            Invoke("HideZone", 1);

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Filter"))
        {
            Dropzone.gameObject.SetActive(false);

        }

    }

    public void HideZone()
    {
        Dropzone.gameObject.SetActive(false);
    }
}
