using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTest : MonoBehaviour
{
    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public ParticleSystem Sanitizer;

    private void Start()
    {
        Sanitizer.Stop();  
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("VRhands"))
        {

            Fire();
            Sanitizer.Play();
            audioSource.PlayOneShot(audioClip);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("VRhands"))
        {

            Fire();
            Sanitizer.Stop();


        }
    }
    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
        Destroy(spawnedBullet, 2);
    }
}
