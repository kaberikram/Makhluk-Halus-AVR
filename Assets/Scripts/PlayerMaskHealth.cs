using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskHealth : MonoBehaviour
{
    public static int Mask;
    public GameObject Green;
    public GameObject Red;
    public GameObject VirusW;
    public GameObject HishamBody;
    public GameObject LoseP;

    
    public AudioSource watchSource;
    public AudioClip watchClip;
    //public AudioSource warningSource;
    //public AudioClip warningClip;
    public AudioSource DSource;
    public AudioClip DClip;
    public AudioSource VhitSource;
    public AudioClip VhitClip;
    public GameObject Mask1, Mask2, Mask3, Maskp1, Maskp2, Maskp3;
    /*private bool KlusterHit = false;
    private float KlusterHitAgainTime = 4f;
    private float canHitAgain;*/
    public Fader otherscript;

    // Start is called before the first frame update
    void Start()
    {

        Green.gameObject.SetActive(true);
        Red.gameObject.SetActive(false);
        VirusW.SetActive(false);
        
      

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
                otherscript.GetComponent<Fader>().hitam();
                Invoke("Kalah", 1.0f);

                DSource.PlayOneShot(DClip);

                break;

        }

        /*if (KlusterHit == true)
        {
            KlusterHit = false;
            warningSource.PlayOneShot(warningClip);

        }*/
    }

    void Kalah()
    {
        HishamBody.transform.position = LoseP.transform.position;
        otherscript.GetComponent<Fader>().putih();
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
        /*if (other.gameObject.CompareTag("WarningTrigger") && canHitAgain < Time.time)
        {
            canHitAgain = Time.time + KlusterHitAgainTime;
            KlusterHit = true;

        }*/


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