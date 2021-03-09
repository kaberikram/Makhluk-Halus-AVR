using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newrotator : MonoBehaviour
{

    public static int Button;
    public float smooth = 1f;
    public GameObject platform;
    private Quaternion targetRotation;
    public GameObject Info;


    void Start()
    {

        targetRotation = platform.transform.rotation;
      
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            targetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
        }
        platform.transform.rotation = Quaternion.Lerp(platform.transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VRhands"))
        {
            targetRotation *= Quaternion.AngleAxis(90, Vector3.up);
            Debug.Log("hit");
            Info.gameObject.SetActive(true);
        }
        platform.transform.rotation = Quaternion.Lerp(platform.transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);


    }
}
    

