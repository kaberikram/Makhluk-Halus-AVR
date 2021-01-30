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

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Filter"))
        {
            Dropzone.gameObject.SetActive(false);

        }

    }
}
