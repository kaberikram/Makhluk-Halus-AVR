using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonpress2 : MonoBehaviour
{
    public GameObject buttonOri;
    public GameObject buttonPressed;
    public GameObject buttondePressed;
    public GameObject Mask;
    public GameObject Frame1;
    public AudioSource buttonSource;
    public AudioClip buttonClip;
    public AudioSource DropSource;
    public AudioClip DropClip;



    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Mask.SetActive(false);
        Frame1.SetActive(false);

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        float step = speed * Time.deltaTime;
        if (other.gameObject.CompareTag("VRhands"))
        {
            buttonOri.transform.position = Vector3.MoveTowards(buttonOri.transform.position, buttonPressed.transform.position, step);
            buttonSource.PlayOneShot(buttonClip);
            DropSource.PlayOneShot(DropClip);
            Frame1.SetActive(true);
            Invoke("Balik", 0.4f);
        }
    }

    void Balik()
    {
        float step = speed * Time.deltaTime;
        buttonOri.transform.position = Vector3.MoveTowards(buttonOri.transform.position, buttondePressed.transform.position, step);
        Mask.SetActive(true);
    }
}
