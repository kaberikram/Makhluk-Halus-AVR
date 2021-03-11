using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskHealth : MonoBehaviour
{
    public static int Mask;
    public GameObject Green;
    public GameObject Red;
    public GameObject VirusW;
    public GameObject HishamD;
    public GameObject RestartCube;
    public AudioSource watchSource;
    public AudioClip watchClip;
    public AudioSource DSource;
    public AudioClip DClip;
    public AudioSource VhitSource;
    public AudioClip VhitClip;
    public GameObject Mask1, Mask2, Mask3, Maskp1, Maskp2, Maskp3;


    // Start is called before the first frame update
    void Start()
    {

        Green.gameObject.SetActive(true);
        Red.gameObject.SetActive(false);
        VirusW.SetActive(false);
        RestartCube.SetActive(false);
        HishamD.SetActive(false);

        Mask = 4;
        Mask1.gameObject.SetActive(true);
        Mask2.gameObject.SetActive(true);
        Mask3.gameObject.SetActive(true);
        Maskp1.gameObject.SetActive(true);
        Maskp2.gameObject.SetActive(true);
        Maskp3.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Mask > 4)
            Mask = 4;
        switch (Mask)
        {
            case 4:
                Mask1.gameObject.SetActive(true);
                Mask2.gameObject.SetActive(true);
                Mask3.gameObject.SetActive(true);
                Maskp1.gameObject.SetActive(true);
                Maskp2.gameObject.SetActive(true);
                Maskp3.gameObject.SetActive(true);
                break;
            case 3:
                Mask1.gameObject.SetActive(true);
                Mask2.gameObject.SetActive(true);
                Mask3.gameObject.SetActive(false);
                Maskp1.gameObject.SetActive(true);
                Maskp2.gameObject.SetActive(true);
                Maskp3.gameObject.SetActive(false);
                break;
            case 2:
                Mask1.gameObject.SetActive(true);
                Mask2.gameObject.SetActive(false);
                Mask3.gameObject.SetActive(false);
                Maskp1.gameObject.SetActive(true);
                Maskp2.gameObject.SetActive(false);
                Maskp3.gameObject.SetActive(false);
                break;
            case 1:
                Mask1.gameObject.SetActive(false);
                Mask2.gameObject.SetActive(false);
                Mask3.gameObject.SetActive(false);
                Maskp1.gameObject.SetActive(false);
                Maskp2.gameObject.SetActive(false);
                Maskp3.gameObject.SetActive(false);
                break;


            case 0:
                Mask1.gameObject.SetActive(false);
                Mask2.gameObject.SetActive(false);
                Mask3.gameObject.SetActive(false);
                Maskp1.gameObject.SetActive(false);
                Maskp2.gameObject.SetActive(false);
                Maskp3.gameObject.SetActive(false);
                VirusW.SetActive(true);
                RestartCube.SetActive(true);
                HishamD.SetActive(true);
                DSource.PlayOneShot(DClip);

                break;

        }
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Virus"))
        {
            Mask -= 1;
            VhitSource.PlayOneShot(VhitClip);
            Red.gameObject.SetActive(false);
            Green.gameObject.SetActive(true);
            Debug.Log("Mask lose 1");
        }
        if (other.gameObject.CompareTag("VirusBound"))
        {
            Red.gameObject.SetActive(true);
            Green.gameObject.SetActive(false);
            watchSource.PlayOneShot(watchClip);
           
        }
        if (other.gameObject.CompareTag("VirusSmall"))
        {
           
            VhitSource.PlayOneShot(VhitClip);
            Mask -= 1;
            Debug.Log("Mask lose 1");
        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("VirusBound"))
        {
            Red.gameObject.SetActive(false);
            Green.gameObject.SetActive(true);
        }

    }



}