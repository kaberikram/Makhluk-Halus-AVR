using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    //Sound


    private bool on = false;
    private bool buttonHit = false;
    private GameObject button;

    public float buttonDownDistance = 0.025f;
    public float buttonReturnSpeed = 0.001f;
    private float buttonOriginalY;

    //timer
    private float buttonHitAgainTime = 0.5f;
    private float canHitAgain;

    // Start is called before the first frame update
    void Start()
    {
        button = transform.GetChild(0).gameObject;
        buttonOriginalY = button.transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonHit == true)
        {
            buttonHit = false;

            button.transform.position = new Vector3(button.transform.position.x, button.transform.position.y - buttonDownDistance, button.transform.position.z);

        }

        if (button.transform.position.y < buttonOriginalY)
        {
            button.transform.position += new Vector3(0, buttonReturnSpeed, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VRhands") && canHitAgain < Time.time)
        {
            canHitAgain = Time.time + buttonHitAgainTime;
            buttonHit = true;
        }
    }


}
