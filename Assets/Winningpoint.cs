using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winningpoint : MonoBehaviour
{
    public GameObject VirusD;
    public GameObject HishamW;
    public GameObject RestartCube;
    public AudioSource MenangSource;
    public AudioClip MenangClip;


    // Start is called before the first frame update
    void Start()
    {
        VirusD.gameObject.SetActive(false);
        HishamW.gameObject.SetActive(false);
        RestartCube.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("vrPlayer"))
        {
            VirusD.gameObject.SetActive(true);
            HishamW.gameObject.SetActive(true);
            RestartCube.gameObject.SetActive(true);
            MenangSource.PlayOneShot(MenangClip);
        }

    }
}
