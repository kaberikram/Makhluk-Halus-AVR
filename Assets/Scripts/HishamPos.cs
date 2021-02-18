using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HishamPos : MonoBehaviour
{
    public GameObject IconMain;
    public GameObject NextPos;

    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        float step = speed * Time.deltaTime;
        if (other.gameObject.CompareTag("vrPlayer"))
        {
            IconMain.transform.position = Vector3.MoveTowards(IconMain.transform.position, NextPos.transform.position, step);
        }



    }
}