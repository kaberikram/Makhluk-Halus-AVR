using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorPlatformVR : MonoBehaviour
{
    public static int Button;
    public float smooth = 1f;
    private Quaternion targetRotation;
    public GameObject Info1, Info2, Info3, Info4;


    void Start()
    {
        Button = 0;
        targetRotation = transform.rotation;
        Info1.gameObject.SetActive(true);
        Info2.gameObject.SetActive(false);
        Info3.gameObject.SetActive(false);
        Info4.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Button > 3)
            Button = 3;
        switch (Button)
        {
            case 3:
                Info1.gameObject.SetActive(false);
                Info2.gameObject.SetActive(false);
                Info3.gameObject.SetActive(false);
                Info4.gameObject.SetActive(true);

                break;
            case 2:
                Info1.gameObject.SetActive(false);
                Info2.gameObject.SetActive(false);
                Info3.gameObject.SetActive(true);
                Info4.gameObject.SetActive(false);

                break;
            case 1:
                Info1.gameObject.SetActive(false);
                Info2.gameObject.SetActive(true);
                Info3.gameObject.SetActive(false);
                Info4.gameObject.SetActive(false);

                break;


            case 0:
                Info1.gameObject.SetActive(true);
                Info2.gameObject.SetActive(false);
                Info3.gameObject.SetActive(false);
                Info4.gameObject.SetActive(false);

                break;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Button += 1;
            targetRotation *= Quaternion.AngleAxis(90, Vector3.forward);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W))
        {
            Button -= 1;
            targetRotation *= Quaternion.AngleAxis(-90, Vector3.forward);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * smooth * Time.deltaTime);
    }
}
