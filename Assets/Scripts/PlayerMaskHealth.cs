using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaskHealth : MonoBehaviour
{
    public static int Mask;
    public GameObject Green;
    public GameObject Red;
    public GameObject Mask1, Mask2, Mask3, Maskp1, Maskp2, Maskp3;


    // Start is called before the first frame update
    void Start()
    {

        Green.gameObject.SetActive(true);
        Red.gameObject.SetActive(false);

        Mask = 3;
        Mask1.gameObject.SetActive(true);
        Mask2.gameObject.SetActive(true);
        Mask3.gameObject.SetActive(true);
        Maskp1.gameObject.SetActive(true);
        Maskp2.gameObject.SetActive(true);
        Maskp3.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Mask > 3)
            Mask = 3;
        switch (Mask)
        {
            case 3:
                Mask1.gameObject.SetActive(true);
                Mask2.gameObject.SetActive(true);
                Mask3.gameObject.SetActive(true);
                Maskp1.gameObject.SetActive(true);
                Maskp2.gameObject.SetActive(true);
                Maskp3.gameObject.SetActive(true);
                break;
            case 2:
                Mask1.gameObject.SetActive(true);
                Mask2.gameObject.SetActive(true);
                Mask3.gameObject.SetActive(false);
                Maskp1.gameObject.SetActive(true);
                Maskp2.gameObject.SetActive(true);
                Maskp3.gameObject.SetActive(false);
                break;
            case 1:
                Mask1.gameObject.SetActive(true);
                Mask2.gameObject.SetActive(false);
                Mask3.gameObject.SetActive(false);
                Maskp1.gameObject.SetActive(true);
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
                break;

        }
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Virus"))
        {
            Mask -= 1;
            Red.gameObject.SetActive(false);
            Green.gameObject.SetActive(true);
            Debug.Log("Mask lose 1");
        }
        if (other.gameObject.CompareTag("VirusBound"))
        {
            Red.gameObject.SetActive(true);
            Green.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("VirusSmall"))
        {
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